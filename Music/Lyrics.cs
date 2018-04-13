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
    public partial class Lyrics : UserControl
    {
        public Lyrics()
        {
            InitializeComponent();
        }
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
        public Image SongImage
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
        public string LyricsText
        {
            get
            {
                return lblLyrics.Text;
            }
            set
            {
                lblLyrics.Text = value;
            }
        }
       
        public event EventHandler btnBack_click;

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (btnBack_click != null)
                btnBack_click(this, e);
            
        }
    }
}
