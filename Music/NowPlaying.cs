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
    public partial class NowPlaying : UserControl
    {
        public NowPlaying()
        {
            InitializeComponent();
        }
        public Song song
        {
            set
            {
                panelSongs.Controls.Add(value);
                //value.Dock = DockStyle.Top;
            }
        }
        public List<Song> listSong
        {
            get
            {
                List<Song> listSong = new List<Song>();
                foreach (Control item in panelSongs.Controls)
                {
                    listSong.Add(item as Song);
                }
                return listSong;
            }
        }
        public Control ScrollControl
        {
            set
            {
                panelSongs.ScrollControlIntoView(value);
            }
        }
        public void Clear()
        {
            panelSongs.Controls.Clear();
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
        public event EventHandler Panel_SizeChanged;

        private void panelSongs_SizeChanged(object sender, EventArgs e)
        {
            if (Panel_SizeChanged != null) Panel_SizeChanged(this, e);
        }
    }
}
