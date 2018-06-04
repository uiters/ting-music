using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music
{
    public partial class fLocalFiles : Form
    {
        public static string Folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\PlayPlist";
        public static string Path = Folder + @"\LocalFiles.txt";
        public fLocalFiles()
        {
            InitializeComponent();
            if (!Directory.Exists(Folder))
                Directory.CreateDirectory(Folder);
            if (!File.Exists(Path))
                File.Create(Path);
            LoadLocalFiles();
        }
        public void LoadLocalFiles()
        {
            panelLocalFiles.Controls.Clear();
            string[] arrLocalFile = ShowLocalFiles();
            for (int i = 0; i < arrLocalFile.Length; i++)
            {
                LocalFiles localFiles = new LocalFiles();
                localFiles.FolderPath = arrLocalFile[i];
                localFiles.Title = GetTitle(arrLocalFile[i]);
                panelLocalFiles.Controls.Add(localFiles);
                localFiles.LocalFiles_Click += LocalFiles_LocalFiles_Click;
            }
        }

        private void LocalFiles_LocalFiles_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("If you remove the \"Music\" folder from Music, it won't appear in Music anymore, but won't be deleted.", "Remove this folder?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                LocalFiles localFiles = sender as LocalFiles;
                RemovePath(localFiles.FolderPath);
                LoadLocalFiles();
            }
        }
        
        public static string[] ShowLocalFiles()
        {
            string filePath = Path;
            if (!Directory.Exists(Folder))
                Directory.CreateDirectory(Folder);
            if (!File.Exists(Path))
                File.Create(Path);
            return File.ReadAllLines(filePath);
        }
        public bool IsPathExists(string path, string folderPath)
        {
            var lines = File.ReadAllLines(folderPath).ToList();
            foreach (var item in lines)
            {
                if (item == path)
                    return true;
            }
            return false;
        }
        public void  SaveLocalFiles(string path)
        {
            string folderPath =fLocalFiles.Path;
            var lines = File.ReadAllLines(folderPath).ToList();
            if (lines.Count() > 0)
            {
                if (!IsPathExists(path, folderPath))
                    lines.Insert(lines.Count() - 1, path);
                File.WriteAllLines(folderPath, lines);
            }
            else
                File.WriteAllLines(folderPath,new string[] { path});
            
        }
        public void RemovePath(string path)
        {
            string folderPath = fLocalFiles.Path;
            var lines = File.ReadAllLines(folderPath).ToList();
            foreach (var item in lines)
            {
                if (item==path)
                {
                    lines.Remove(item);
                    break;
                }
            }
            File.WriteAllLines(folderPath, lines);
        }
        public string GetTitle(string path)
        {
            string[] title = path.Split('\\');
            return title[title.Count() - 1];
        }
        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            
            Close();
        }
        private void addLocalFiles_AddLocalFiles_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.ShowNewFolderButton = false;
            if (folder.ShowDialog() == DialogResult.OK)
            {
                LocalFiles localFiles = new LocalFiles();
                localFiles.FolderPath = folder.SelectedPath;
                localFiles.LocalFiles_Click += LocalFiles_LocalFiles_Click;
                localFiles.Title = GetTitle(folder.SelectedPath);
                panelLocalFiles.Controls.Add(localFiles);
                SaveLocalFiles(folder.SelectedPath);
            }
        }

        private void addLocalFiles1_LocalFiles_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.ShowNewFolderButton = false;
            if (folder.ShowDialog() == DialogResult.OK)
            {
                LocalFiles localFiles = new LocalFiles();
                localFiles.FolderPath = folder.SelectedPath;
                localFiles.LocalFiles_Click += LocalFiles_LocalFiles_Click;
                localFiles.Title = GetTitle(folder.SelectedPath);
                panelLocalFiles.Controls.Add(localFiles);
                SaveLocalFiles(folder.SelectedPath);
            }
        }
    }
}
