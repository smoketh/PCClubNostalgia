using LiteDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCClubNostalgia
{
    public partial class Form1 : Form
    {
        public class VConfig
        {
            public ObjectId Id { get; set; }
            public int pcNumber { get; set; }
            public string nick { get; set; }
            public string traffic { get; set; }
            public string message { get; set; }
            public string timeStatus { get; set; }
        }
        System.Timers.Timer secUpdater;
        TabControlV nCont;
        public LiteDatabase db;
        public LiteCollection<AppPather> paths;
        public LiteCollection<VConfig> vcfgc;
        List<AppPather> lst;
        public VConfig vcfg;

        private void OnApplicationExit(object sender, EventArgs e)
        {
            
            if (secUpdater != null) secUpdater.Stop();
        }

        public Form1()
        {
            Application.ApplicationExit += new EventHandler(this.OnApplicationExit);
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            db= new LiteDatabase(@"Software.db");
            paths = db.GetCollection<AppPather>() as LiteCollection<AppPather>;
            vcfgc = db.GetCollection<VConfig>() as LiteCollection<VConfig>;
            if(vcfgc.Count()==0)
            {
                vcfg = new VConfig()
                {
                    pcNumber = 2,
                    message = "Все впорядке. Время идёт...\r\nОплачено: Кровно заработанными Окончание: Как получится",
                    nick = "user",
                    timeStatus = "Начало:   Вчера   Окончание:    Завтра   Осталось:   Сегодня",
                    traffic = ""
                };
                vcfgc.Insert(vcfg);
            }
            else
                vcfg = vcfgc.FindAll().ToList()[0];

            //this.tabMain.DrawMode = TabDrawMode.OwnerDrawFixed;
            //this.tabMain.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabMain_DrawItem);
            nCont = new TabControlV();
            nCont.Location = new Point(25, 25);
            //nCont.edge
            nCont.Dock = DockStyle.Fill;
            //nCont.
            nCont.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                    | System.Windows.Forms.AnchorStyles.Left)
                    | System.Windows.Forms.AnchorStyles.Right)));
            nCont.Location = new Point(3, 128);
            Rectangle screenRectangle = RectangleToScreen(this.ClientRectangle);
            int titleHeight = screenRectangle.Top - this.Top;
            nCont.Size = new Size(this.Width-24, this.Height-128-12- titleHeight);
            nCont.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
            secUpdater = new System.Timers.Timer();
            secUpdater.BeginInit();
            secUpdater.Interval = 1000;
            secUpdater.Elapsed += OnTimedEvent;
            secUpdater.EndInit();
            secUpdater.Start();

            //   AddTab("Quake");
            //AddTab("Test2");
            //nCont.TabPages.Add(tabMain.TabPages[0]);
            this.Controls.Add(nCont);
            nCont.BringToFront();
            
            InitComponents();
            AddApps();
            nCont.SelectedIndexChanged += SortTabRedo;
            UpdateTime();
        }


        public void AddApps()
        {

            lblMsg.Text = vcfg.message;
            lblNick.Text = vcfg.nick;
            lblNum.Text = vcfg.pcNumber.ToString();
            lblTimeMessage.Text = vcfg.timeStatus;
            lblTraffic.Text = vcfg.traffic;
            nCont.TabPages.Clear();
            if (paths.Count() == 0)
            {
                AppPather nPth = new AppPather()
                {
                    category = "Office",
                    name = "Notepad",
                    path = @"C:\Windows\notepad.exe",
                    iconPath = @"C:\Windows\notepad.exe"
                };
                paths.Insert(nPth);
            }
            lst = paths.FindAll().ToList();
            
            List<string> Categories = new List<string>();
            foreach (AppPather appath in lst)
            {
                if (!Categories.Contains(appath.category))
                {
                    Categories.Add(appath.category);
                }
            }
            
            foreach (string category in Categories)
            {
                var nTab = AddTab(category);
                var cCatLst = lst.Where(x => x.category == category).ToList();
                foreach (AppPather appath in cCatLst)
                {
                    Button vBtn = new Button();
                    vBtn.Tag = appath.Id;
                    vBtn.Name = "vbtn" + appath.Id.ToString();
                    vBtn.Parent = nTab;
                    //vBtn.Location = new Point(5+)
                    vBtn.TextImageRelation = TextImageRelation.Overlay;
                    vBtn.ImageAlign = ContentAlignment.MiddleCenter;
                    vBtn.TextAlign = ContentAlignment.MiddleCenter;
                    if (appath.iconPath == "" || appath.iconPath==null) appath.iconPath = appath.path;
                    if (System.IO.File.Exists(appath.iconPath))
                    {
                        Icon ico = Icon.ExtractAssociatedIcon(appath.iconPath);
                        vBtn.Image = ico.ToBitmap();
                        
                        vBtn.TextAlign = ContentAlignment.BottomCenter;
                    }
                    vBtn.FlatStyle = FlatStyle.Popup;
                    vBtn.ForeColor = Color.Red;
                    vBtn.Text = appath.name;
                    vBtn.Click += OpenApp;
                }
            }
            if (nCont.TabCount > 0)
            {
                nCont.SelectTab(0);
                SortTabButtons();
            }
            nCont.Invalidate();

        }

        const int BTNWIDTH = 105;
        const int BTNHEIGHT = 99;
        const int BTNSKIP = 2;

        void SortTabRedo(object sender, EventArgs e)
        {
            SortTabButtons();
        }

        void SortTabButtons()
        {
            if (nCont == null || nCont.SelectedTab == null) return;
            if(nCont.SelectedTab.HasChildren)
            {

                int maxX = nCont.SelectedTab.Width/(BTNWIDTH+BTNSKIP);
                int x = 0;
                int y = 0;
                for(int q=0; q<nCont.SelectedTab.Controls.Count; q++) // (Control childControl in nCont.SelectedTab.Controls)
                {
                    if (nCont.SelectedTab.Controls[q] is Button)
                    {
                        var btn = nCont.SelectedTab.Controls[q] as Button;
                        btn.Location = new Point(
                            BTNSKIP + (BTNWIDTH + BTNSKIP) * x,
                            BTNSKIP + (BTNHEIGHT+ BTNSKIP) * y);
                        btn.Size = new Size(BTNWIDTH, BTNHEIGHT);
                        x++;
                        if(x>=maxX)
                        {
                            x = 0;
                            y++;
                        }
                    }
                }
            }
        }

        public void OpenApp(object sender, EventArgs e)
        {
            var btn = sender as Button;
            var obj = paths.FindOne(x => x.Id == btn.Tag as ObjectId);
            if (obj == null) return;
            if(System.IO.File.Exists(obj.path))
            {
                Process.Start(obj.path);
            }
            
        }

        TabPage AddTab(string name)
        {
            var tPage1 = new TabPage(name);
            tPage1.BackColor = Color.Black;
            tPage1.ForeColor = Color.White;
            nCont.TabPages.Add(tPage1);
            return tPage1;
        }

        Bitmap GetImageFromInt(int i)
        {
            switch(i)
            {
                case 0: return PCClubNostalgia.Properties.Resources.D0;
                case 1: return PCClubNostalgia.Properties.Resources.D1;
                case 2: return PCClubNostalgia.Properties.Resources.D2;
                case 3: return PCClubNostalgia.Properties.Resources.D3;
                case 4: return PCClubNostalgia.Properties.Resources.D4;
                case 5: return PCClubNostalgia.Properties.Resources.D5;
                case 6: return PCClubNostalgia.Properties.Resources.D6;
                case 7: return PCClubNostalgia.Properties.Resources.D7;
                case 8: return PCClubNostalgia.Properties.Resources.D8;
                case 9: return PCClubNostalgia.Properties.Resources.D9;
                default: return PCClubNostalgia.Properties.Resources.D0;
            }
        }

        private void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            UpdateTime();
        }
        void UpdateTime()
        {
            
            label2.Text = System.DateTime.Now.ToString("dd.MM.yyyy");
            //Console.WriteLine(System.DateTime.Now.Hour);
            pbH.Image = GetImageFromInt(System.DateTime.Now.Hour / 10);
            pbH2.Image = GetImageFromInt(System.DateTime.Now.Hour % 10);
            pbM.Image = GetImageFromInt(System.DateTime.Now.Minute / 10);
            pbM2.Image = GetImageFromInt(System.DateTime.Now.Minute % 10);
        }

        void InitComponents()
        {
            //var pages = tabMain.TabPages;

            //pages.Add("test");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }



        private void btReboot_Click(object sender, EventArgs e)
        {
            FormReloaded child = new FormReloaded();
            child.Owner = this;
            //child.tParent = this;
            child.Show();
        }
        int cNum = 2;
        private void lblNum_Click(object sender, EventArgs e)
        {
            /*bool control = ModifierKeys.HasFlag(Keys.Control);
            bool alt = ModifierKeys.HasFlag(Keys.Alt);
            int change = 1;
            if (control) change = -1;
            if (alt) change *= 10;
            cNum=cNum+change;
            lblNum.Text = cNum.ToString();*/
        }

        private void btOptions_Click(object sender, EventArgs e)
        {
            FormApps child = new FormApps();
            child.Owner = this;
            child.tParent = this;
            child.Show();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            SortTabButtons();
        }
        bool wasDisabledBefore = false;
        private void Form1_EnabledChanged(object sender, EventArgs e)
        {



            if (!this.Enabled)
            {
                if (secUpdater!=null) secUpdater.Stop();
                wasDisabledBefore = true;
            }
            else
            {
                if (!wasDisabledBefore) return;
                if (secUpdater != null) secUpdater.Start();
                AddApps();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblMsg_Click(object sender, EventArgs e)
        {
            if(ModifierKeys.HasFlag(Keys.Control))
            {
                System.IO.Stream str = Properties.Resources.Notify;
                System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                snd.Play();
            }
            else
            {
                System.IO.Stream str = Properties.Resources.NotifyClean;
                System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                snd.Play();
            }
        }

        private void btShutdown_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            vcfg.message = lblMsg.Text;
            vcfg.nick = lblNick.Text;
            vcfg.pcNumber = System.Convert.ToInt32(lblNum.Text);
            vcfg.timeStatus = lblTimeMessage.Text;
            vcfg.traffic = lblTraffic.Text;
            vcfgc.DeleteAll();
            vcfgc.Insert(vcfg);
        }
    }
}
