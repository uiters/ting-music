using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music
{
    public partial class fProperties : Form
    {
        public fProperties(string mediaPath)
        {
            InitializeComponent();
            LoadProperties(mediaPath);
        }
        public void LoadProperties(string mediaPath)
        {
            songTitle.Text = SongInfo.GetTitle(mediaPath);
            songArtist.Text = SongInfo.GetArtist(mediaPath);
            albumtitle.Text = SongInfo.GetAlbum(mediaPath);
            albumArtist.Text = SongInfo.GetAlbumArtist(mediaPath);
            genre.Text = SongInfo.GetGenrne(mediaPath);
            length.Text = SongInfo.GetLength(mediaPath);
            year.Text = SongInfo.GetYear(mediaPath);
            copyright.Text = SongInfo.GetCopyright(mediaPath);
            fileLocation.Text = mediaPath;
        }
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
