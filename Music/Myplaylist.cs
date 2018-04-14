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
    public partial class Myplaylist : UserControl
    {
        public Myplaylist()
        {
            InitializeComponent();
        }
        public event EventHandler BtnImage_Click;
        public Image PlaylistImage
        {
            get
            {
                return btnImage.BackgroundImage;
            }
            set
            {
                btnImage.BackgroundImage = value;
            }
        }
        public string PlaylistName
        {
            get
            {
                return labelPlaylistName.Text;
            }
            set
            {
                labelPlaylistName.Text = value;
            }
        }
        private void btnImage_Click(object sender, EventArgs e)
        {
            if (BtnImage_Click != null)
                BtnImage_Click(this, e);
        }
    }
}
