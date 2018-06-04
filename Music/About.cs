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
    }
}
