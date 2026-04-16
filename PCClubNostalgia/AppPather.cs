//using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCClubNostalgia
{
    public class AppPather
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string category { get; set; } = "null";
        public string name { get; set; } = "Notepad";
        public string path { get; set; } = @"C:\Windows\notepad.exe";
        public string iconPath { get; set; } = @"C:\Windows\notepad.exe";
        public int iconIndex { get; set; } = 0;
        public string launchParams { get; set; } = "";
        
    }

    
}
