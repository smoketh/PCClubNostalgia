using GlacialComponents.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCClubNostalgia
{
    public partial class FormApps : Form
    {
        public Form1 tParent;
        //BindingSource biding1;
        public FormApps()
        {
            InitializeComponent();
            var vPath = System.Reflection.Assembly.GetExecutingAssembly().CodeBase;
            var lPath = System.IO.Path.GetDirectoryName(vPath);
            //label1.Text = lPath;
            //LiteDB.l
            //if (tParent == null) throw new Exception("No owner?");
            
            tParent = Application.OpenForms["Form1"] as Form1;
            
            Rebind();
            //dataGridMain.DataSource = tParent.paths.FindAll();
            //tParent.vcfg.pcNumber = (int)
            numericUpDown1.Value = tParent.config.pcNumber;
            tbUsrName.Text = tParent.config.nick;
            tbTraffic.Text = tParent.config.traffic;
            tbTimeLabel.Text = tParent.config.timeStatus;
            tbMessage.Text = tParent.config.message;

        }

        void UpdateDB(object sender, EventArgs e)
        {
            Console.WriteLine("Durr");
        }

        void Rebind()
        {
            
            glacialList1.Items.Clear();
            //dataGridMain.DataSource = new List<AppPather>();
            if (tParent.config.paths.Count() != 0)
            {
                //var lst=tParent.config.paths.FindAll().ToList();
                foreach(AppPather appath in tParent.config.paths)
                {
                    var item = this.glacialList1.Items.Add(appath.category);
                    item.SubItems[1].Text = appath.name;
                    //(item.SubItems[1].Control as TextBox).LostFocus += UpdateDB;
                    item.SubItems[2].Text = appath.path;
                    item.SubItems[4].Text = appath.iconPath;
                    item.SubItems[6].Text = appath.iconIndex.ToString();
                    item.SubItems[7].Text = appath.launchParams;
                    item.Tag = appath.Id;
                    
                }
            }
                //dataGridMain.DataSource = tParent.paths.FindAll().ToList();
        }

        private void FormApps_Load(object sender, EventArgs e)
        {
            this.Owner.Enabled = false;
        }

        private void FormApps_FormClosed(object sender, FormClosedEventArgs e)
        {
            tParent.config.paths.Clear();
            foreach(GLItem item in glacialList1.Items)
            {
                int resultIndex;
                var iconParseSucc = int.TryParse(item.SubItems[6].Text, out resultIndex);
                if (iconParseSucc == false) resultIndex = 0;

                AppPather updated = new AppPather()
                {
                    category = item.SubItems[0].Text,
                    name = item.SubItems[1].Text,
                    path = item.SubItems[2].Text,
                    iconPath = item.SubItems[4].Text,
                    iconIndex = resultIndex,
                    launchParams = item.SubItems[7].Text
                };
                tParent.config.paths.Add(updated);
                /*if (item.Tag !=null)
                {
                    updated.Id= item.Tag as LiteDB.ObjectId;
                    tParent.paths.Update(updated);
                }
                else
                {
                    
                }*/

            }
            label1.Focus();
            tParent.config.pcNumber=(int)numericUpDown1.Value;
            tParent.config.nick = tbUsrName.Text;
            tParent.config.traffic = tbTraffic.Text;
            tParent.config.timeStatus = tbTimeLabel.Text;
            tParent.config.message = tbMessage.Text;
            tParent.SaveRegularConfig();
            //tParent.config.DeleteAll();
            //tParent.config.Insert(tParent.vcfg);
            this.Owner.Enabled = true;
            //tParent.AddApps();
        }

        /*private void dataGridMain_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //bindingSource1.EndEdit();
            //if (e.RowIndex != bindingSource1.IndexOf(bindingSource1.Current)) return;
            AppPather contact = (dataGridMain.DataSource as List<AppPather>)[e.RowIndex]; //bindingSource1[e.RowIndex] as AppPather;
            if (dataGridMain.CurrentCell.ColumnIndex==0)
            {
                contact.name = (string)dataGridMain.CurrentCell.Value;
            }
            else
            {
                contact.path = (string)dataGridMain.CurrentCell.Value;
            }
            //AppPather contact = bindingSource1[e.RowIndex] as AppPather;
            if (contact != null)
            {
                if(!tParent.paths.Update(contact))
                {
                    throw new Exception("WHAT?!");
                }

            }
            Rebind();
        }*/
        /*
        private void btnAdd_Click(object sender, EventArgs e)
        {
            bindingSource1.Add(new AppPather() { name = "New App", path = "C:/" });
            bindingSource1.MoveLast();
            //tParent.paths.Insert(new AppPather() { name = "New App", path = "C:/" });

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }
        */


        private void btnAdd_Click(object sender, EventArgs e)
        {
            //tParent.paths.Insert(new AppPather());
            //Rebind();
            var item = this.glacialList1.Items.Add("Empty");
            item.SubItems[1].Text = "Notepad";
            item.SubItems[2].Text = @"C:\Windows\notepad.exe";
            item.SubItems[4].Text = @"C:\Windows\notepad.exe";
            item.SubItems[6].Text = "0";
            item.SubItems[7].Text = "";
            this.glacialList1.Invalidate();
            //this.glacialList1.Update();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if ((int)glacialList1.SelectedIndicies.Count == 0) return;
            var test = (Guid)glacialList1.Items[(int)glacialList1.SelectedIndicies[0]].Tag; //(glacialList1.SelectedItems[0] as GLItem).Tag;
            if (test != null)
            {
                var cItm=tParent.config.paths.Find(x => x.Id == test);
            }

            glacialList1.Items.RemoveAt((int)glacialList1.SelectedIndicies[0]);
            this.glacialList1.Invalidate();
            btnFileSelect.Visible = false;
            btnIconSelect.Visible = false;
            //else 
            //AppPather contact = bindingSource1.Current as AppPather;
            //tParent.paths.Delete(contact.Id);
            //Rebind();
            //tParent.paths.Update();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            Console.WriteLine((bindingSource1.Current as AppPather).name);
        }

        private void glacialList1_SelectedIndexChanged(object source, ClickEventArgs e)
        {
            Console.WriteLine(e.ItemIndex);
            btnFileSelect.Visible = true;
            btnIconSelect.Visible = true;
            AlignButtons(e.ItemIndex);
            
                
            //glacialList1.Items[e.ItemIndex].SubItems[3].LastCellRect
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            if(glacialList1.Items[(int)glacialList1.SelectedIndicies[0]].SubItems[2].Text==
                glacialList1.Items[(int)glacialList1.SelectedIndicies[0]].SubItems[4].Text)
            {
                glacialList1.Items[(int)glacialList1.SelectedIndicies[0]].SubItems[4].Text =
                openFileDialog1.FileNames[0];
            }
            glacialList1.Items[(int)glacialList1.SelectedIndicies[0]].SubItems[2].Text=
                openFileDialog1.FileNames[0];
            //if(glacialList1.Items[(int)glacialList1.SelectedIndicies[0]].SubItems[4].Text)
            //Console.WriteLine(System.IO.Path.GetExtension(openFileDialog1.FileNames[0]));
            //if(System.IO.Path.GetExtension( openFileDialog1.FileNames[0])==".lnk")
        }

        private void btnFileSelect_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            glacialList1.Items[(int)glacialList1.SelectedIndicies[0]].SubItems[4].Text =
                openFileDialog2.FileNames[0];


            
        }

        private void btnIconSelect_Click(object sender, EventArgs e)
        {
            if(openFileDialog2.ShowDialog(this) == DialogResult.OK)
            {
                string cFile;
                int cIndex;
                var mFileName = glacialList1.Items[(int)glacialList1.SelectedIndicies[0]].SubItems[4].Text;
                bool iconPicked = IconPicker.Show(this.Handle, out cFile, out cIndex, mFileName);
                if (iconPicked)
                {
                    glacialList1.Items[(int)glacialList1.SelectedIndicies[0]].SubItems[4].Text = cFile;
                    glacialList1.Items[(int)glacialList1.SelectedIndicies[0]].SubItems[6].Text = cIndex.ToString();
                }
            }
        }

        private void glacialList1_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void btnMvUp_Click(object sender, EventArgs e)
        {
            if ((int)glacialList1.SelectedIndicies.Count == 0) return;
            var index = (int)glacialList1.SelectedIndicies[0];
            if (index == 0) return;
            var item = glacialList1.Items[(int)glacialList1.SelectedIndicies[0]];
            glacialList1.Items.RemoveAt(index);
            glacialList1.Items.Insert(index - 1, item);
            glacialList1.Invalidate();
            AlignButtons(index);
        }

        private void btnMvDn_Click(object sender, EventArgs e)
        {
            if ((int)glacialList1.SelectedIndicies.Count == 0) return;
            var index = (int)glacialList1.SelectedIndicies[0];
            if (index == glacialList1.Count-1) return;
            var item = glacialList1.Items[(int)glacialList1.SelectedIndicies[0]];
            glacialList1.Items.RemoveAt(index);
            glacialList1.Items.Insert(index + 1, item);
            glacialList1.Invalidate();
            AlignButtons(index);
        }

        void AlignButtons(int index)
        {
            var rect = glacialList1.Items[index].SubItems[3].LastCellRect;
            btnFileSelect.Location = new Point(glacialList1.Left + rect.Left, glacialList1.Top + rect.Top);
            var rect2= glacialList1.Items[index].SubItems[5].LastCellRect;
            btnIconSelect.Location = new Point(glacialList1.Left + rect2.Left, glacialList1.Top + rect2.Top);
        }

        private void glacialList1_Click(object sender, EventArgs e)
        {

        }

        /*private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            tParent.vcfg.pcNumber = (int)numericUpDown1.Value;
        }*/
    }
}
