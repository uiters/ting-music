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
        private UpdateMusic update;
        public event EventHandler CloseForm;
        public Setting()
        {
            InitializeComponent();

            
            cbMinute.Text = "15";
            lblTime.Text = fMusic.ConvertToMinute(15*60);

            update = new UpdateMusic(label); ;
            update.CloseForm += Update_CloseForm;
        }

        private void Update_CloseForm(object sender, EventArgs e)
        {
            this.CloseForm?.Invoke(null, null);

        }
        Timer ShutDownTimer;
   
        int i = 0;
        private void ShutDownTimer_Tick(object sender, EventArgs e)
        {
            if(i>=0)
            {
                lblTime.Text = fMusic.ConvertToMinute(i);
                i--;
            }
            else
            {
                Timer timer = sender as Timer;
                timer.Stop();
                timer.Dispose();
                Application.Exit();
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            fLocalFiles fLocalFiles = new fLocalFiles();
            fLocalFiles.ShowDialog();
        }

        private void btnShutDown_OnValueChange(object sender, EventArgs e)
        {
            if (btnShutDown.Value)
            {

                lblStatus.Text = "On";
                cbMinute.Enabled = true;
                lblTime.ForeColor = Color.FromArgb(239, 108, 1);
                ShutDownTimer = new Timer();
                ShutDownTimer.Interval = 1000;
                ShutDownTimer.Start();
                ShutDownTimer.Tick += ShutDownTimer_Tick;
                i = int.Parse(cbMinute.Text) * 60;
            }
            else
            {
                lblStatus.Text = "Off";
                lblTime.Text = "00:00";
                cbMinute.Enabled = false;
                lblTime.ForeColor = Color.FromArgb(92, 92, 92);
                ShutDownTimer.Stop();
                ShutDownTimer.Dispose();
            }
        }

        private void cbMinute_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            i = int.Parse(cbMinute.Text) * 60;
        }

        private void btnNowPlaying_Click(object sender, EventArgs e)
        {
            if (update.IsUpdating == false)
            {
                lbStatus.Visible = true;
                label.Visible = true;
                update.CheckInternet();
            }
            else return;
        }
    }
}
