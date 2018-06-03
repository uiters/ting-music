using Ionic.Zip;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace InstallUpdate
{
    class Program
    {
        static void Main(string[] args)
        {
            string zipLink = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Music\Music.zip";
            string linkExtract = AppDomain.CurrentDomain.BaseDirectory;
            string app = linkExtract + @"\Music.exe";
            Thread.Sleep(1000);
            if (File.Exists(zipLink))
            {
                using (ZipFile zip = ZipFile.Read(zipLink))
                {
                    zip.ExtractAll(linkExtract, ExtractExistingFileAction.OverwriteSilently);
                }
            }
            else
            {
                if (File.Exists(linkExtract))
                    Process.Start(linkExtract);
                return;
            }
            return;
        }
    }
}
