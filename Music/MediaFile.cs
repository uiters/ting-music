using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music
{
    class MediaFile
    {
        string fileName;
        string filePath;
        public MediaFile() { }
        public MediaFile(string filePath)
        {
            FilePath = filePath;
            FileName = filePath.Substring(filePath.LastIndexOf("\\") + 1);
        }

        public string FileName { get => fileName; set => fileName = value; }
        public string FilePath { get => filePath; set => filePath = value; }
    }
}
