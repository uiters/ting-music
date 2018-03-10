using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;

namespace Music
{
    public partial class MyMusic : UserControl
    {
        public MyMusic()
        {
            InitializeComponent();
            btnShuffleAllAlbums.IconVisible = true;
            btnShuufleAllArtists.IconVisible = true;
            btnShuffleAllSongs.IconVisible = true;
            var materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Orange800, Primary.Green200, Primary.Lime700, Accent.Amber400, TextShade.WHITE);
        }

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void materialTabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
    }
}
