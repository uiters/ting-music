using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Resources;
using System.Globalization;

namespace Music
{
    public partial class Playlist : UserControl
    {
        public Playlist()
        {
            InitializeComponent();
        }
        public void ShowLanguage(ResourceManager resourceManager, CultureInfo cultureInfo)
        {
            btnNewPlaylist.Text = resourceManager.GetString("btnNewPlaylist", cultureInfo);
            label1.Text = resourceManager.GetString("labelSort", cultureInfo);
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
