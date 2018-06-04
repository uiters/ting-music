using System;
using System.Collections.Generic;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Music
{
    public partial class PlaylistDetail : UserControl
    {
        public PlaylistDetail()
        {
            InitializeComponent();
        }
        public event EventHandler PlayAll_Click;
        
        public event EventHandler Rename_Click;
        public event EventHandler Delete_Click;
        public void AddSong(Song value)
        {
            panelSongs.Controls.Add(value);
        }
        public static Image CropImage(Image img)
        {
            Rectangle cropArea = new Rectangle(Point.Empty,new Size(img.Size.Width, img.Size.Height/4));
            Bitmap bmpImage = new Bitmap(img);
            Bitmap bmpCrop = bmpImage.Clone(cropArea,bmpImage.PixelFormat);
            return (Image)(bmpCrop);
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
                background.BackgroundImage =new Bitmap(CropImage(value));
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
        public Song Song
        {
            set
            {
                panelSongs.Controls.Add(value);
            }
        }
        public int TotalSong
        {
            set
            {
                lblTotalSong.Text = value.ToString()+" songs";
            }
        }
        public List<Song> ListSong
        {
            get
            {
                return panelSongs.Controls.Cast<Song>().ToList();
            }
        }

        public void SetScrollControl(Control value)
        {
            panelSongs.ScrollControlIntoView(value);
        }
        public List<Control> GetControls
        {
            get
            {
                return panelSongs.Controls.Cast<Control>().ToList();
            }
        }
        public void Clear()
        {
            panelSongs.Controls.Clear();
        }

        

        private void btnPlayAll_Click_2(object sender, EventArgs e)
        {
            PlayAll_Click?.Invoke(this, e);
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            Rename_Click?.Invoke(this, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete_Click?.Invoke(this, e);
        }
    }
}
