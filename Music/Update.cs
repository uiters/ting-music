using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    public partial class fMusic
    {
        private readonly Uri uriVersion = new Uri("https://drive.google.com/uc?export=download&id=1hCCUwe6QJijZXF-viQ7tWgn85QibDVeX");
        private readonly Uri uriUpdate = new Uri("https://drive.google.com/uc?export=download&id=1g4rgesTuGIDkDVvr2DnL7W0DNeKHI97I");
        private readonly string source = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Music";
        private readonly string zipFile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Music\Music.zip";
        private readonly string txtFile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Music\version.txt";
        private readonly string installLink = Application.StartupPath + @"\install.ext";

        private void GetVersionAvailable()
        {
            if(Directory.Exists(source))
            {
                Directory.Delete(source, true);
            }
            Directory.CreateDirectory(source);
            Thread.Sleep(200);
            using (WebClient web = new WebClient())
            {
                web.DownloadFileCompleted += Web_DownloadFileVersionCompleted;
                web.DownloadFileAsync(uriVersion, txtFile);
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (File.Exists(zipFile))
                File.Delete(zipFile);
            Thread.Sleep(200);
            using (WebClient web = new WebClient())
            {
                web.DownloadFileCompleted += Web_DownloadFileZipCompleted;
                web.DownloadProgressChanged += Web_DownloadProgressChanged;
                web.DownloadFileAsync(uriUpdate, zipFile);
            }
        }

        private void Web_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            
        }

        private void Web_DownloadFileZipCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            if (File.Exists(installLink))
            {
                ProcessStartInfo install = new ProcessStartInfo(installLink);
                install.Verb = "runas";
                install.CreateNoWindow = false;
                install.UseShellExecute = false;
                Process.Start(install);
                Application.Exit();
            }
            else return;
        }

        private void Web_DownloadFileVersionCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            using (StreamReader reader = new StreamReader(txtFile))
            {
                string version = reader.ReadLine();
                reader.Close();
            }
        }
    }

    class InternetConnection
    {
        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int description, int reservedValuine);
        public static bool IsConnectedToInternet()
        {
            return InternetGetConnectedState(out int desc, 0);
        }
    }
}
