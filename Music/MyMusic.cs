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
    public partial class MyMusic : UserControl
    {
        public MyMusic()
        {
            InitializeComponent();
        }
        public Song song
        {
            set
            {
                panelSongs.Controls.Add(value);
                value.Dock = DockStyle.Top;
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

    }
}
