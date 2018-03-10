using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace Music
{
    public partial class fMusic : Form
    {
        Image pause; 
        Image play;
        Image repeat;
        Image repeat_one;
        Image volume_off;
        Image volume_up;
        public fMusic()
        {
            InitializeComponent();
            LoadData();
           
        }
        public void LoadData()
        {
            panelLeft.Width = 223;
            panelPlay.Location = new Point(455, 21);
            repeat = Music.Properties.Resources.repeat;
            repeat_one = Music.Properties.Resources.repeat_one;
            btnRepeat.Iconimage = repeat;
            volume_off = Music.Properties.Resources.volume_off;
            volume_up = Music.Properties.Resources.volume_up;
            btnVolume.Iconimage = volume_up;
            pause = Music.Properties.Resources.pause;
            play = Music.Properties.Resources.play;
            btnPlay.Image = pause;
        }
        public void ChangeNormalColorOnPanel1(object sender)
        {
            BunifuFlatButton btn = sender as BunifuFlatButton;
            btn.Normalcolor = Color.FromArgb(239, 108, 1);
            foreach (Control item in panel1.Controls)
            {
                if (item.Name != btn.Name && item.BackColor != Color.Transparent)
                {
                    BunifuFlatButton btn1 = item as BunifuFlatButton;
                    btn1.Normalcolor = Color.Transparent;
                    
                }
            }
        }


       
     
        private void btnBack_Click(object sender, EventArgs e)
        {

        }
        private void btnNavigationPanel_Click_1(object sender, EventArgs e)
        {
            if (panelLeft.Width == 223)
            {
                panelLeft.Width = 55;
            }
            else
            {
                panelLeft.Width = 223;
            }
        }

        private void btnMyMusic_Click_1(object sender, EventArgs e)
        {
            ChangeNormalColorOnPanel1(sender);
        }

        private void btnRecentPlays_Click_1(object sender, EventArgs e)
        {
            ChangeNormalColorOnPanel1(sender);
        }

        private void btnNowPlaying_Click_1(object sender, EventArgs e)
        {
            ChangeNormalColorOnPanel1(sender);
        }

        private void btnPlayList_Click_1(object sender, EventArgs e)
        {
            ChangeNormalColorOnPanel1(sender);
        }

        private void btnSetting_Click_1(object sender, EventArgs e)
        {
            ChangeNormalColorOnPanel1(sender);
        }

        private void btnAbout_Click_1(object sender, EventArgs e)
        {
            ChangeNormalColorOnPanel1(sender);
        }
        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Maximized;
                panelPlay.Location = new Point(601, 21);
                //1143  624
                //1135 thông số của panel 1143, 624 của panel lúc full
                //bunifuSlider1.Value = 50; cần cập nhật value cho control này khi maxmize để tránh làm nát form
            }
            else
            {
                WindowState = FormWindowState.Normal;
                panelPlay.Location = new Point(455, 21);
            }
           
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

     

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            if (btnShuffle.Normalcolor == Color.Transparent)
            {
                btnShuffle.Normalcolor = Color.FromArgb(239, 108, 1);
            }
            else
            {
                btnShuffle.Normalcolor = Color.Transparent;
            }
        }

        private void btnRepeat_Click(object sender, EventArgs e)
        {
            if (btnRepeat.Normalcolor == Color.Transparent)
            {
                btnRepeat.Normalcolor = Color.FromArgb(239, 108, 1);
               
            }
            else
            {
                if(btnRepeat.Iconimage==repeat)
                {
                    btnRepeat.Iconimage = repeat_one;
                }
                else
                {
                    btnRepeat.Iconimage = repeat;
                    btnRepeat.Normalcolor = Color.Transparent;
                }
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if(btnPlay.Image== pause)
            {
                btnPlay.Image = play;
 
            }
           else
            {
                btnPlay.Image = pause;
            }
        }

        private void btnVolume_Click(object sender, EventArgs e)
        {
            if(btnVolume.Iconimage==volume_up)
            {
                btnVolume.Iconimage = volume_off;
            }
            else
            {
                btnVolume.Iconimage = volume_up;
            }
        }

        private void myMusic1_Load(object sender, EventArgs e)
        {

        }
    }
}
