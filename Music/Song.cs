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
    public partial class Song : UserControl
    {
        Image pause;
        Image play;
        public Song()
        {
            InitializeComponent();
            pause = Music.Properties.Resources.pause;
            play = Music.Properties.Resources.play;
            btnPlay.Image = play;
        }
        public event EventHandler ButtonPlay_Click;
        public event EventHandler ButtonOption_Click;
        public string SongName
        {
            get
            {
                return lblSongName.Text;
            }
            set
            {
                lblSongName.Text = value;
            }
        }
        public string ArtistName
        {
            get
            {
                return lblArtistName.Text;
            }
            set
            {
                lblArtistName.Text = value;
            }

        }
        public string CategoryName
        {
            get
            {
                return lblCategory.Text;
            }
            set
            {
                lblCategory.Text = value;
            }
        }
        public string TotalTime
        {
            get
            {
                return lblTotalTime.Text;
            }
            set
            {
                lblTotalTime.Text = value;
            }
        }
        public Image ImageSong
        {
            get
            {
                return pictureBoxSong.Image;
            }
            set
            {
                pictureBoxSong.Image = value;
            }
        }
        public Image ImageButton
        {
            get
            {
                return btnPlay.Image;
            }
            set
            {
                btnPlay.Image = value;
            }
        }
        public int index
        {
            get
            {
                return (int)lblTotalTime.Tag;
            }
            set
            {
                lblTotalTime.Tag = value;
            }
        }
        private void btnPlay_Click_1(object sender, EventArgs e)
        {
            if(ButtonPlay_Click!=null)
            ButtonPlay_Click(this, e);
            //if (btnPlay.Image == pause)
            //{
            //    btnPlay.Image = play;
            //}
            //else
            //{
            //    btnPlay.Image = pause;
            //}
        }

        private void btnOption_Click(object sender, EventArgs e)
        {
            if(ButtonOption_Click!=null)
            ButtonOption_Click(this, e);
        }
    }
}
