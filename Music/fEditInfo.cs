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
    public partial class fEditInfo : Form
    {
        string _mediaPath;
        public fEditInfo(string mediaPath)
        {
            InitializeComponent();
            _mediaPath = mediaPath;
            LoadProperties(mediaPath);
        }
        public void LoadProperties(string mediaPath)
        {
            txbSongtitle.Text = SongInfo.GetTitle(mediaPath);
            txbSongArtist.Text = SongInfo.GetArtist(mediaPath);
            txbAlbumTitle.Text = SongInfo.GetAlbum(mediaPath);
            txbAlbumArtist.Text = SongInfo.GetAlbumArtist(mediaPath);
            txbGerne.Text = SongInfo.GetGenrne(mediaPath);
            txbYear.Text = SongInfo.GetYear(mediaPath);
            fileLocation.Text = mediaPath;
        }
        public void EditInfo()
        {
            SongInfo.Save(_mediaPath, txbSongtitle.Text, txbSongArtist.Text, txbAlbumTitle.Text, txbAlbumArtist.Text, txbGerne.Text, uint.Parse(txbYear.Text));
        }
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to edit information this playlist?", "Quesition", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                EditInfo();
                MessageBox.Show("Edit information successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void txbYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
