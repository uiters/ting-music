using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music
{
    public class UpdateMusic
    {
        private static readonly Uri uriVersion = new Uri("https://drive.google.com/uc?export=download&id=1hCCUwe6QJijZXF-viQ7tWgn85QibDVeX");
        private static readonly Uri uriUpdate = new Uri("https://drive.google.com/uc?export=download&id=1g4rgesTuGIDkDVvr2DnL7W0DNeKHI97I");
        private static readonly string source = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Music";
        private static readonly string zipFile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Music\Music.zip";
        public  static readonly string installLink = Application.StartupPath + @"\InstallUpdate.exe";
        public bool IsUpdating = false;
        private Label label;


        public event EventHandler CloseForm;
        public UpdateMusic(Label label)
        {
            this.label = label;
        }


        public void CheckInternet()
        {
            if (InternetConnection.IsConnectedToInternet() == false)
            {
                MessageBox.Show("No Internet", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else GetVersionAvailable();
        }

        public void GetVersionAvailable()
        {
            IsUpdating = true;
            if (Directory.Exists(source))
            {
                Directory.Delete(source, true);
            }
            Directory.CreateDirectory(source);
            Thread.Sleep(200);
            using (WebClient web = new WebClient())
            {
                web.DownloadStringCompleted += Web_DownloadStringCompleted;
                label.Visible = true;
                label.Text = "Check version";
                web.DownloadStringAsync(uriVersion);
            }
        }

        private void Web_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            if (e.Result != Properties.Settings.Default.version)
            {
                label.Text = "Downloading...";
                Update_Click(sender, null);
            } else label.Text = "No Update";
        }
        private void Update_Click(object sender, EventArgs e)
        {
            if (File.Exists(zipFile))
                File.Delete(zipFile);
            Thread.Sleep(200);
            using (WebClient web = new WebClient())
            {
                web.DownloadFileCompleted += Web_DownloadFileZipCompleted;
                web.DownloadFileAsync(uriUpdate, zipFile);
            }
        }

        private void Web_DownloadFileZipCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            label.Text = "Ting will automatically install update the next time";
            CloseForm?.Invoke(null, null);
            IsUpdating = false;
        }

    }

    public class InternetConnection
    {
        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int description, int reservedValuine);
        public static bool IsConnectedToInternet()
        {
            return InternetGetConnectedState(out int desc, 0);
        }
    }

}
