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
    public partial class AlbumDetails : UserControl
    {
        public AlbumDetails()
        {
            InitializeComponent();
        }
        public Image PlaylistImage
        {
            get
            {
                return image.Image;
            }
            set
            {
                image.Image = value;
                background.BackgroundImage= new Bitmap(PlaylistDetail.CropImage(value));
            }
        }
        public string PlaylistName
        {
            get
            {
                return lblPlaylistName.Text;
            }
            set
            {
                lblPlaylistName.Text = value;
            }
        }
        public int totalSong
        {
            set
            {
                lblTotalSong.Text = value.ToString() + " songs";
            }
        }
    }
}
