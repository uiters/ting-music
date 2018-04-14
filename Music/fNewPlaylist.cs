using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music
{
    public partial class fNewPlaylist : Form
    {
        public fNewPlaylist()
        {
            InitializeComponent();
        }

        public string playlistName;

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNewPlaylist_Click(object sender, EventArgs e)
        {
            if(txbNewPlaylist.Text!=string.Empty)
            playlistName = txbNewPlaylist.Text;
            else
            {

            }

            this.Close();
        }
    }
}
