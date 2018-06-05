using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using System.Globalization;

namespace Music
{
    public partial class Results : UserControl
    {
        private string text = string.Empty;

        public Results()
        {
            InitializeComponent();
        }
        public void ShowLanguage(ResourceManager resource, CultureInfo culture)
        {
            text = resource.GetString("lblSongSearch", culture);
        }
        public string Title
        {
            set
            {
                lblResults.Text = text + value + "\"";
            }
        }
        public void AddSongs(List<Song> songs)
        {
            foreach (var item in songs)
            {
                panelSongs.Controls.Add(item);
            }
        }
        public void Clear()
        {
            panelSongs.Controls.Clear();
        }
    }
}
