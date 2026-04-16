using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace PCClubNostalgia
{


    public static class IconPicker
    {
        // We call it by ordinal #62 because it's not exported by name in all Windows versions
        [DllImport("shell32.dll", EntryPoint = "#62", CharSet = CharSet.Auto)]
        private static extern int PickIconDlg(
            IntPtr hwndOwner,
            StringBuilder lpstrFile,
            int nMaxFile,
            ref int lpdwIconIndex);

        public static bool Show(IntPtr ownerHandle, out string selectedPath, out int selectedIndex, string initialPath = "shell32.dll", int initialIndex = 0)
        {
            StringBuilder sb = new StringBuilder(initialPath, 260); // MAX_PATH is 260
            int index = initialIndex;

            // Returns 1 if the user clicked OK, 0 if they cancelled
            int result = PickIconDlg(ownerHandle, sb, sb.Capacity, ref index);

            if (result != 0)
            {
                selectedPath = sb.ToString();
                selectedIndex = index;
                return true;
            }

            selectedPath = null;
            selectedIndex = -1;
            return false;
        }
    }

    public static class IconHelper
    {
        // The core WinAPI function
        [DllImport("shell32.dll", CharSet = CharSet.Auto)]
        private static extern int ExtractIconEx(string szFileName, int nIconIndex, IntPtr[] phiconLarge, IntPtr[] phiconSmall, int nIcons);

        // Need this to clean up memory, otherwise you'll leak handles
        [DllImport("user32.dll", SetLastError = true)]
        static extern bool DestroyIcon(IntPtr hIcon);

        public static Bitmap GetIconFromFile(string path, int iconIndex = 0, bool largeIcon = true)
        {
            if (!File.Exists(path)) return null;
            int totalIcons = ExtractIconEx(path, -1, null, null, 0);

            // 2. Fail if the file has no icons or is invalid (-1)
            if (totalIcons <= 0) return null;

            IntPtr[] largeIcons = new IntPtr[1];
            IntPtr[] smallIcons = new IntPtr[1];

            // Extract the icon at the specific index
            int readIconCount = ExtractIconEx(path, iconIndex, largeIcons, smallIcons, 1);

            if (readIconCount > 0)
            {
                IntPtr handle = largeIcon ? largeIcons[0] : smallIcons[0];

                // Create the managed Icon object
                using (Icon icon = Icon.FromHandle(handle))
                {
                    Bitmap bmp = icon.ToBitmap();

                    // Cleanup: WinAPI requires us to manually destroy the handle we created
                    DestroyIcon(largeIcons[0]);
                    DestroyIcon(smallIcons[0]);

                    return bmp;
                }
            }

            return null;
        }
    }
}

