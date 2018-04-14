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
    public partial class Playlist : UserControl
    {
        public Playlist()
        {
            InitializeComponent();
        }
        public event EventHandler NewPlaylist_Click;
        public Myplaylist myplaylist
        {
            set
            {
                panelSongs.Controls.Add(value);
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

        private void btnNewPlaylist_Click(object sender, EventArgs e)
        {
            if (NewPlaylist_Click != null)
                NewPlaylist_Click(this, e);
        }
    }
}
