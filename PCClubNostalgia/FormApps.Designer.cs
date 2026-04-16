namespace PCClubNostalgia
{
    partial class FormApps
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
            this.components = new System.ComponentModel.Container();
            GlacialComponents.Controls.GLColumn glColumn9 = new GlacialComponents.Controls.GLColumn();
            GlacialComponents.Controls.GLColumn glColumn10 = new GlacialComponents.Controls.GLColumn();
            GlacialComponents.Controls.GLColumn glColumn11 = new GlacialComponents.Controls.GLColumn();
            GlacialComponents.Controls.GLColumn glColumn12 = new GlacialComponents.Controls.GLColumn();
            GlacialComponents.Controls.GLColumn glColumn13 = new GlacialComponents.Controls.GLColumn();
            GlacialComponents.Controls.GLColumn glColumn14 = new GlacialComponents.Controls.GLColumn();
            GlacialComponents.Controls.GLColumn glColumn15 = new GlacialComponents.Controls.GLColumn();
            GlacialComponents.Controls.GLColumn glColumn16 = new GlacialComponents.Controls.GLColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormApps));
            this.label1 = new System.Windows.Forms.Label();
            this.glacialList1 = new GlacialComponents.Controls.GlacialList();
            this.btnFileSelect = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnIconSelect = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.btnMvDn = new System.Windows.Forms.Button();
            this.btnMvUp = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUsrName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTraffic = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTimeLabel = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Номер Компьютера";
            // 
            // glacialList1
            // 
            this.glacialList1.AllowColumnResize = true;
            this.glacialList1.AllowDrop = true;
            this.glacialList1.AllowMultiselect = false;
            this.glacialList1.AlternateBackground = System.Drawing.Color.DarkGreen;
            this.glacialList1.AlternatingColors = false;
            this.glacialList1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.glacialList1.AutoHeight = true;
            this.glacialList1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.glacialList1.BackgroundStretchToFit = true;
            glColumn9.ActivatedEmbeddedType = GlacialComponents.Controls.GLActivatedEmbeddedTypes.TextBox;
            glColumn9.CheckBoxes = false;
            glColumn9.ImageIndex = -1;
            glColumn9.Name = "cCat";
            glColumn9.NumericSort = false;
            glColumn9.Text = "Категория";
            glColumn9.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            glColumn9.Width = 100;
            glColumn10.ActivatedEmbeddedType = GlacialComponents.Controls.GLActivatedEmbeddedTypes.TextBox;
            glColumn10.CheckBoxes = false;
            glColumn10.ImageIndex = -1;
            glColumn10.Name = "cName";
            glColumn10.NumericSort = false;
            glColumn10.Text = "Название";
            glColumn10.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            glColumn10.Width = 100;
            glColumn11.ActivatedEmbeddedType = GlacialComponents.Controls.GLActivatedEmbeddedTypes.None;
            glColumn11.CheckBoxes = false;
            glColumn11.ImageIndex = -1;
            glColumn11.Name = "сPath";
            glColumn11.NumericSort = false;
            glColumn11.Text = "Путь";
            glColumn11.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            glColumn11.Width = 200;
            glColumn12.ActivatedEmbeddedType = GlacialComponents.Controls.GLActivatedEmbeddedTypes.UserType;
            glColumn12.CheckBoxes = false;
            glColumn12.ImageIndex = -1;
            glColumn12.Name = "fSel";
            glColumn12.NumericSort = false;
            glColumn12.Text = "Column";
            glColumn12.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            glColumn12.Width = 17;
            glColumn13.ActivatedEmbeddedType = GlacialComponents.Controls.GLActivatedEmbeddedTypes.None;
            glColumn13.CheckBoxes = false;
            glColumn13.ImageIndex = -1;
            glColumn13.Name = "fIcon";
            glColumn13.NumericSort = false;
            glColumn13.Text = "Иконка";
            glColumn13.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            glColumn13.Width = 200;
            glColumn14.ActivatedEmbeddedType = GlacialComponents.Controls.GLActivatedEmbeddedTypes.None;
            glColumn14.CheckBoxes = false;
            glColumn14.ImageIndex = -1;
            glColumn14.Name = "fSelIC";
            glColumn14.NumericSort = false;
            glColumn14.Text = "Column";
            glColumn14.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            glColumn14.Width = 17;
            glColumn15.ActivatedEmbeddedType = GlacialComponents.Controls.GLActivatedEmbeddedTypes.TextBox;
            glColumn15.CheckBoxes = false;
            glColumn15.ImageIndex = -1;
            glColumn15.Name = "fICID";
            glColumn15.NumericSort = false;
            glColumn15.Text = "Номер Иконки";
            glColumn15.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            glColumn15.Width = 100;
            glColumn16.ActivatedEmbeddedType = GlacialComponents.Controls.GLActivatedEmbeddedTypes.TextBox;
            glColumn16.CheckBoxes = false;
            glColumn16.ImageIndex = -1;
            glColumn16.Name = "fParams";
            glColumn16.NumericSort = false;
            glColumn16.Text = "Параметры";
            glColumn16.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            glColumn16.Width = 100;
            this.glacialList1.Columns.AddRange(new GlacialComponents.Controls.GLColumn[] {
            glColumn9,
            glColumn10,
            glColumn11,
            glColumn12,
            glColumn13,
            glColumn14,
            glColumn15,
            glColumn16});
            this.glacialList1.ControlStyle = GlacialComponents.Controls.GLControlStyles.Normal;
            this.glacialList1.FullRowSelect = true;
            this.glacialList1.GridColor = System.Drawing.Color.LightGray;
            this.glacialList1.GridLines = GlacialComponents.Controls.GLGridLines.gridBoth;
            this.glacialList1.GridLineStyle = GlacialComponents.Controls.GLGridLineStyles.gridSolid;
            this.glacialList1.GridTypes = GlacialComponents.Controls.GLGridTypes.gridOnExists;
            this.glacialList1.HeaderHeight = 22;
            this.glacialList1.HeaderVisible = true;
            this.glacialList1.HeaderWordWrap = false;
            this.glacialList1.HotColumnTracking = false;
            this.glacialList1.HotItemTracking = false;
            this.glacialList1.HotTrackingColor = System.Drawing.Color.LightGray;
            this.glacialList1.HoverEvents = false;
            this.glacialList1.HoverTime = 1;
            this.glacialList1.ImageList = null;
            this.glacialList1.ItemHeight = 17;
            this.glacialList1.ItemWordWrap = false;
            this.glacialList1.Location = new System.Drawing.Point(12, 100);
            this.glacialList1.Name = "glacialList1";
            this.glacialList1.Selectable = true;
            this.glacialList1.SelectedTextColor = System.Drawing.Color.White;
            this.glacialList1.SelectionColor = System.Drawing.Color.DarkBlue;
            this.glacialList1.ShowBorder = true;
            this.glacialList1.ShowFocusRect = false;
            this.glacialList1.Size = new System.Drawing.Size(838, 335);
            this.glacialList1.SortType = GlacialComponents.Controls.SortTypes.InsertionSort;
            this.glacialList1.SuperFlatHeaderColor = System.Drawing.Color.White;
            this.glacialList1.TabIndex = 4;
            this.glacialList1.Text = "glacialList1";
            this.glacialList1.SelectedIndexChanged += new GlacialComponents.Controls.GlacialList.ClickedEventHandler(this.glacialList1_SelectedIndexChanged);
            this.glacialList1.Click += new System.EventHandler(this.glacialList1_Click);
            this.glacialList1.DragDrop += new System.Windows.Forms.DragEventHandler(this.glacialList1_DragDrop);
            // 
            // btnFileSelect
            // 
            this.btnFileSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFileSelect.Location = new System.Drawing.Point(413, 307);
            this.btnFileSelect.Margin = new System.Windows.Forms.Padding(0);
            this.btnFileSelect.Name = "btnFileSelect";
            this.btnFileSelect.Size = new System.Drawing.Size(17, 17);
            this.btnFileSelect.TabIndex = 5;
            this.btnFileSelect.Text = "...";
            this.btnFileSelect.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFileSelect.UseVisualStyleBackColor = true;
            this.btnFileSelect.Visible = false;
            this.btnFileSelect.Click += new System.EventHandler(this.btnFileSelect_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DereferenceLinks = false;
            this.openFileDialog1.Filter = "Executables|*.exe";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // btnIconSelect
            // 
            this.btnIconSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnIconSelect.Location = new System.Drawing.Point(630, 307);
            this.btnIconSelect.Margin = new System.Windows.Forms.Padding(0);
            this.btnIconSelect.Name = "btnIconSelect";
            this.btnIconSelect.Size = new System.Drawing.Size(17, 17);
            this.btnIconSelect.TabIndex = 8;
            this.btnIconSelect.Text = "...";
            this.btnIconSelect.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIconSelect.UseVisualStyleBackColor = true;
            this.btnIconSelect.Visible = false;
            this.btnIconSelect.Click += new System.EventHandler(this.btnIconSelect_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.DereferenceLinks = false;
            this.openFileDialog2.Filter = "Icon Containers(*.exe, *.ico, *.dll)|*.exe;*.ico;*.dll";
            this.openFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog2_FileOk);
            // 
            // btnMvDn
            // 
            this.btnMvDn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMvDn.Image = global::PCClubNostalgia.Properties.Resources.LockWin_ARRDOWN_ICO;
            this.btnMvDn.Location = new System.Drawing.Point(135, 441);
            this.btnMvDn.Name = "btnMvDn";
            this.btnMvDn.Size = new System.Drawing.Size(35, 23);
            this.btnMvDn.TabIndex = 7;
            this.btnMvDn.UseVisualStyleBackColor = true;
            this.btnMvDn.Click += new System.EventHandler(this.btnMvDn_Click);
            // 
            // btnMvUp
            // 
            this.btnMvUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMvUp.Image = global::PCClubNostalgia.Properties.Resources.LockWin_ARRUP_ICO;
            this.btnMvUp.Location = new System.Drawing.Point(94, 441);
            this.btnMvUp.Name = "btnMvUp";
            this.btnMvUp.Size = new System.Drawing.Size(35, 23);
            this.btnMvUp.TabIndex = 6;
            this.btnMvUp.UseVisualStyleBackColor = true;
            this.btnMvUp.Click += new System.EventHandler(this.btnMvUp_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemove.Image = global::PCClubNostalgia.Properties.Resources.LockWin_CANCEL_ICO;
            this.btnRemove.Location = new System.Drawing.Point(53, 441);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(35, 23);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.Image = global::PCClubNostalgia.Properties.Resources.LockWin_MAKE_ICO;
            this.btnAdd.Location = new System.Drawing.Point(12, 441);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(35, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(142, 7);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 9;
            this.numericUpDown1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Имя Пользователя";
            // 
            // tbUsrName
            // 
            this.tbUsrName.Location = new System.Drawing.Point(142, 33);
            this.tbUsrName.Name = "tbUsrName";
            this.tbUsrName.Size = new System.Drawing.Size(120, 20);
            this.tbUsrName.TabIndex = 11;
            this.tbUsrName.Text = "user";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Траффик";
            // 
            // tbTraffic
            // 
            this.tbTraffic.Location = new System.Drawing.Point(142, 59);
            this.tbTraffic.Name = "tbTraffic";
            this.tbTraffic.Size = new System.Drawing.Size(120, 20);
            this.tbTraffic.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(324, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Сообщение";
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(433, 7);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(417, 46);
            this.tbMessage.TabIndex = 15;
            this.tbMessage.Text = "Все впорядке. Время идёт...\r\nОплачено: Кровно заработанными Окончание: Как получи" +
    "тся";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(324, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Строка времени";
            // 
            // tbTimeLabel
            // 
            this.tbTimeLabel.Location = new System.Drawing.Point(433, 59);
            this.tbTimeLabel.Name = "tbTimeLabel";
            this.tbTimeLabel.Size = new System.Drawing.Size(417, 20);
            this.tbTimeLabel.TabIndex = 17;
            this.tbTimeLabel.Text = "Начало:   Вчера   Окончание:    Завтра   Осталось:   Сегодня";
            // 
            // FormApps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 471);
            this.Controls.Add(this.tbTimeLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbTraffic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbUsrName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btnIconSelect);
            this.Controls.Add(this.btnMvDn);
            this.Controls.Add(this.btnMvUp);
            this.Controls.Add(this.btnFileSelect);
            this.Controls.Add(this.glacialList1);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormApps";
            this.Text = "Приложения";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormApps_FormClosed);
            this.Load += new System.EventHandler(this.FormApps_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private GlacialComponents.Controls.GlacialList glacialList1;
        private System.Windows.Forms.Button btnFileSelect;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnMvUp;
        private System.Windows.Forms.Button btnMvDn;
        private System.Windows.Forms.Button btnIconSelect;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUsrName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTraffic;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTimeLabel;
    }
}