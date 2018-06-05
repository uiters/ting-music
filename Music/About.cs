using System.Globalization;
using System.Resources;
using System.Windows.Forms;

namespace Music
{
    public partial class About : UserControl
    {
        public About()
        {
            InitializeComponent();
            label5.Text = Properties.Settings.Default.version;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:ndc07.it@gmail.com");
        }
        public void ShowLanguage(ResourceManager resource, CultureInfo culture)
        {
            label1.Text =  resource.GetString("version", culture);
            label3.Text = resource.GetString("label_About", culture);
            label4.Text = resource.GetString("label_Contact", culture);
        }
    }
}
