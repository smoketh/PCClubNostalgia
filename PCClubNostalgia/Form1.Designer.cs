namespace PCClubNostalgia
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblNum = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.lblTimeMessage = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNick = new System.Windows.Forms.Label();
            this.lblTraffic = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pbM2 = new System.Windows.Forms.PictureBox();
            this.pbM = new System.Windows.Forms.PictureBox();
            this.pbH2 = new System.Windows.Forms.PictureBox();
            this.pbH = new System.Windows.Forms.PictureBox();
            this.btShutdown = new System.Windows.Forms.Button();
            this.btReboot = new System.Windows.Forms.Button();
            this.btOptions = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbM2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbH2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbH)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNum
            // 
            this.lblNum.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblNum.Font = new System.Drawing.Font("Arial", 100F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblNum.ForeColor = System.Drawing.Color.Yellow;
            this.lblNum.Location = new System.Drawing.Point(772, 0);
            this.lblNum.Margin = new System.Windows.Forms.Padding(0);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(252, 768);
            this.lblNum.TabIndex = 3;
            this.lblNum.Text = "2";
            this.lblNum.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblNum.Click += new System.EventHandler(this.lblNum_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMsg.BackColor = System.Drawing.Color.Blue;
            this.lblMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblMsg.Location = new System.Drawing.Point(3, 3);
            this.lblMsg.Margin = new System.Windows.Forms.Padding(5);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Padding = new System.Windows.Forms.Padding(5);
            this.lblMsg.Size = new System.Drawing.Size(393, 54);
            this.lblMsg.TabIndex = 9;
            this.lblMsg.Text = "Все впорядке. Время идёт...\r\nОплачено: Кровно заработанными Окончание: Как получи" +
    "тся";
            this.lblMsg.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblMsg.Click += new System.EventHandler(this.lblMsg_Click);
            // 
            // lblTimeMessage
            // 
            this.lblTimeMessage.AutoSize = true;
            this.lblTimeMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblTimeMessage.ForeColor = System.Drawing.Color.Yellow;
            this.lblTimeMessage.Location = new System.Drawing.Point(157, 97);
            this.lblTimeMessage.Name = "lblTimeMessage";
            this.lblTimeMessage.Size = new System.Drawing.Size(373, 13);
            this.lblTimeMessage.TabIndex = 10;
            this.lblTimeMessage.Text = "Начало:   Вчера   Окончание:    Завтра   Осталось:   Сегодня";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(648, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "5.09.2020";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(573, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Трафик:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(595, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ник:";
            // 
            // lblNick
            // 
            this.lblNick.AutoSize = true;
            this.lblNick.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblNick.ForeColor = System.Drawing.Color.Yellow;
            this.lblNick.Location = new System.Drawing.Point(633, 71);
            this.lblNick.Name = "lblNick";
            this.lblNick.Size = new System.Drawing.Size(31, 13);
            this.lblNick.TabIndex = 14;
            this.lblNick.Text = "user";
            // 
            // lblTraffic
            // 
            this.lblTraffic.AutoSize = true;
            this.lblTraffic.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblTraffic.ForeColor = System.Drawing.Color.Yellow;
            this.lblTraffic.Location = new System.Drawing.Point(633, 97);
            this.lblTraffic.Name = "lblTraffic";
            this.lblTraffic.Size = new System.Drawing.Size(0, 13);
            this.lblTraffic.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblMsg);
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(160, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 64);
            this.panel1.TabIndex = 16;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.Image = global::PCClubNostalgia.Properties.Resources.DD;
            this.pictureBox5.Location = new System.Drawing.Point(705, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(9, 26);
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            // 
            // pbM2
            // 
            this.pbM2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbM2.Image = global::PCClubNostalgia.Properties.Resources.D0;
            this.pbM2.Location = new System.Drawing.Point(747, 12);
            this.pbM2.Name = "pbM2";
            this.pbM2.Size = new System.Drawing.Size(22, 26);
            this.pbM2.TabIndex = 7;
            this.pbM2.TabStop = false;
            // 
            // pbM
            // 
            this.pbM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbM.Image = global::PCClubNostalgia.Properties.Resources.D0;
            this.pbM.Location = new System.Drawing.Point(717, 12);
            this.pbM.Name = "pbM";
            this.pbM.Size = new System.Drawing.Size(22, 26);
            this.pbM.TabIndex = 6;
            this.pbM.TabStop = false;
            // 
            // pbH2
            // 
            this.pbH2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbH2.Image = global::PCClubNostalgia.Properties.Resources.D0;
            this.pbH2.Location = new System.Drawing.Point(681, 12);
            this.pbH2.Name = "pbH2";
            this.pbH2.Size = new System.Drawing.Size(22, 26);
            this.pbH2.TabIndex = 5;
            this.pbH2.TabStop = false;
            // 
            // pbH
            // 
            this.pbH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbH.Image = global::PCClubNostalgia.Properties.Resources.D0;
            this.pbH.Location = new System.Drawing.Point(651, 12);
            this.pbH.Name = "pbH";
            this.pbH.Size = new System.Drawing.Size(22, 26);
            this.pbH.TabIndex = 4;
            this.pbH.TabStop = false;
            // 
            // btShutdown
            // 
            this.btShutdown.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btShutdown.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btShutdown.FlatAppearance.BorderSize = 2;
            this.btShutdown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btShutdown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btShutdown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btShutdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btShutdown.ForeColor = System.Drawing.Color.Yellow;
            this.btShutdown.Image = global::PCClubNostalgia.Properties.Resources.LockWin_SHUTDOWN_ICO;
            this.btShutdown.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btShutdown.Location = new System.Drawing.Point(6, 80);
            this.btShutdown.Name = "btShutdown";
            this.btShutdown.Size = new System.Drawing.Size(146, 37);
            this.btShutdown.TabIndex = 2;
            this.btShutdown.Text = "       Выключение";
            this.btShutdown.UseVisualStyleBackColor = false;
            this.btShutdown.Click += new System.EventHandler(this.btShutdown_Click);
            // 
            // btReboot
            // 
            this.btReboot.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btReboot.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btReboot.FlatAppearance.BorderSize = 2;
            this.btReboot.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btReboot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btReboot.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btReboot.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btReboot.ForeColor = System.Drawing.Color.Yellow;
            this.btReboot.Image = global::PCClubNostalgia.Properties.Resources.LockWin_RESTART_ICO;
            this.btReboot.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btReboot.Location = new System.Drawing.Point(6, 42);
            this.btReboot.Name = "btReboot";
            this.btReboot.Size = new System.Drawing.Size(146, 37);
            this.btReboot.TabIndex = 1;
            this.btReboot.Text = "         Перезагрузка";
            this.btReboot.UseVisualStyleBackColor = false;
            this.btReboot.Click += new System.EventHandler(this.btReboot_Click);
            // 
            // btOptions
            // 
            this.btOptions.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btOptions.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btOptions.FlatAppearance.BorderSize = 2;
            this.btOptions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btOptions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btOptions.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btOptions.ForeColor = System.Drawing.Color.Yellow;
            this.btOptions.Image = global::PCClubNostalgia.Properties.Resources.LockWin_SETUP2_ICO;
            this.btOptions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btOptions.Location = new System.Drawing.Point(6, 4);
            this.btOptions.Name = "btOptions";
            this.btOptions.Size = new System.Drawing.Size(146, 37);
            this.btOptions.TabIndex = 0;
            this.btOptions.Text = "    Настройка";
            this.btOptions.UseVisualStyleBackColor = false;
            this.btOptions.Click += new System.EventHandler(this.btOptions_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.lblTraffic);
            this.Controls.Add(this.lblNick);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTimeMessage);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pbM2);
            this.Controls.Add(this.pbM);
            this.Controls.Add(this.pbH2);
            this.Controls.Add(this.pbH);
            this.Controls.Add(this.btShutdown);
            this.Controls.Add(this.btReboot);
            this.Controls.Add(this.btOptions);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "Form1";
            this.Text = "PC Club Nostalgia";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.EnabledChanged += new System.EventHandler(this.Form1_EnabledChanged);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbM2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbH2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btOptions;
        private System.Windows.Forms.Button btReboot;
        private System.Windows.Forms.Button btShutdown;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.PictureBox pbH;
        private System.Windows.Forms.PictureBox pbH2;
        private System.Windows.Forms.PictureBox pbM2;
        private System.Windows.Forms.PictureBox pbM;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Label lblTimeMessage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNick;
        private System.Windows.Forms.Label lblTraffic;
        private System.Windows.Forms.Panel panel1;
    }
}

