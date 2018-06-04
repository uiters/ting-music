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
    public partial class Results : UserControl
    {
        public Results()
        {
            InitializeComponent();
        }
        public string Title
        {
            set
            {
                lblResults.Text = "Results for \"" + value + "\"";
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
