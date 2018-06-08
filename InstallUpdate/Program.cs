using Ionic.Zip;
using System;
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
            Thread.Sleep(500);
            if (File.Exists(zipLink))
            {
                try
                {
                    using (ZipFile zip = ZipFile.Read(zipLink))
                    {
                        zip.ExtractAll(linkExtract, ExtractExistingFileAction.OverwriteSilently);
                    }
                }
                catch { return; }
            }
            return;
        }
    }
}
