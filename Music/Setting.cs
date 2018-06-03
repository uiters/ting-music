using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music
{
    public partial class Setting : UserControl
    {
        public Setting()
        {
            InitializeComponent();
        }

        private void Setting_Load(object sender, EventArgs e)
        {

        }

        private void bunifuiOSSwitch1_OnValueChange(object sender, EventArgs e)
        {
            if (btnShutDown.Value)
            {
                //cbMinute.Text = "15";
                lblStatus.Text = "On";
                cbMinute.Enabled = true;
                lblTime.ForeColor = Color.FromArgb(239, 108, 1);
            }
            else
            {
                lblStatus.Text = "Off";
                lblTime.Text = "00:00";
                cbMinute.Enabled = false;
                lblTime.ForeColor = Color.FromArgb(92, 92, 92);
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            fLocalFiles fLocalFiles = new fLocalFiles();
            fLocalFiles.ShowDialog();
        }
    }
}
