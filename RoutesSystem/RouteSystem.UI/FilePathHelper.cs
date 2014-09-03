namespace RouteSystem.UI
{
    internal struct FilePathHelper
    {
        public FilePathHelper(string filePathInfo)
            : this()
        {
            var lastIndexOfSlash = filePathInfo.LastIndexOf(@"\");
            var filePath = filePathInfo.Substring(0, lastIndexOfSlash);
            var fileName = filePathInfo.Substring(lastIndexOfSlash + 1);

            this.FileName = fileName;
            this.FilePath = filePath;
        }

        internal string FilePath { get; set; }

        internal string FileName { get; set; }
    }
}