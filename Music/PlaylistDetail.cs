﻿using System;
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
        public Song song
        {
            set
            {
                panelSongs.Controls.Add(value);
            }
        }
        public int totalSong
        {
            set
            {
                lblTotalSong.Text = value.ToString()+" songs";
            }
        }
        public List<Song> listSong
        {
            get
            {
                List<Song> songs = new List<Song>();
                songs.AddRange(panelSongs.Controls.Cast<Song>());
                return songs;
            }
        }
        public Control ScrollControl
        {
            set
            {
                panelSongs.ScrollControlIntoView(value);
            }
        }
        public List<Control> listControl
        {
            get
            {
                List<Control> listcontrol = new List<Control>();
                foreach (Control item in panelSongs.Controls)
                {
                    listcontrol.Add(item);
                }
                return listcontrol;
            }
        }
        public void Clear()
        {
            panelSongs.Controls.Clear();
        }

        

        private void btnPlayAll_Click_2(object sender, EventArgs e)
        {
            if (PlayAll_Click != null)
                PlayAll_Click(this, e);
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            if (Rename_Click != null)
                Rename_Click(this, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Delete_Click != null)
                Delete_Click(this, e);
        }
    }
}