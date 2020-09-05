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
    public partial class FormReloaded : Form
    {
        public FormReloaded()
        {
            InitializeComponent();
        }

        private void FormReloaded_Load(object sender, EventArgs e)
        {
            this.Owner.Enabled = false;
        }
        private void FormReloaded_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Enabled = true;
        }
    }
}
