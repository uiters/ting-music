namespace Music
{
    class MediaFile
    {
        private string filePath;
        internal MediaFile(string filePath)
        {
            this.filePath = filePath;
        }

        internal string FileName { get => filePath.Substring(filePath.LastIndexOf("\\") + 1); }
        internal string FilePath { get => filePath; }
    }
}
