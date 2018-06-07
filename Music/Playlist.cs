using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Resources;
using System.Globalization;
using System.Linq;

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
        public void AddMyplaylist(Myplaylist value)
        {
            panelSongs.Controls.Add(value);
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

        private void btnNewPlaylist_Click(object sender, EventArgs e)
        {
            if (NewPlaylist_Click != null)
                NewPlaylist_Click(this, e);
        }

        private void ComboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = sender as ComboBox;
            switch (combo.SelectedIndex)
            {
                case 0:
                    Sort_AtoZ();
                    break;
                case 1:
                    Sort_ZtoA();
                    break;
                default:
                    Sort_AtoZ();
                    break;
            }
        }

        private void Sort_ZtoA()
        {
            List<Myplaylist> controls = panelSongs.Controls.Cast<Myplaylist>().ToList();
            controls.Sort(UISort.iCompareArtistZtoA);
            MyMusic.ChangeColor(panelSongs, controls.ToArray());     
        }

        private void Sort_AtoZ()
        {
            List<Myplaylist> controls = panelSongs.Controls.Cast<Myplaylist>().ToList();
            controls.Sort(UISort.iCompareArtistAtoZ);
            MyMusic.ChangeColor(panelSongs, controls.ToArray());
        }
    }
}
