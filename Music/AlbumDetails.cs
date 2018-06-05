using System.Drawing;
using System.Windows.Forms;
using System.Resources;
using System.Globalization;

namespace Music
{
    public partial class AlbumDetails : UserControl
    {
        private static ResourceManager resource;
        private static CultureInfo culture;
        public static void ShowLanguage(ResourceManager resources, CultureInfo cultures)
        {
            culture = cultures;
            resource = resources;
        }
        public AlbumDetails()
        {
            InitializeComponent();
            label2.Text = resource.GetString("Songs", culture);

        }
        public Image ImageShow
        {
            get
            {
                return image.Image;
            }
            set
            {
                image.Image = value;
                background.BackgroundImage= new Bitmap(PlaylistDetail.CropImage(value));
            }
        }
        public string NameFull
        {
            get
            {
                return lblPlaylistName.Text;
            }
            set
            {
                lblPlaylistName.Text = value;
            }
        }
        public int TotalSong
        {
            set
            {
                lblTotalSong.Text = value.ToString();
            }
        }
    }
}
