using System;


namespace R5T.E0047.F001
{
    public class FilePathProvider : IFilePathProvider
    {
        #region Infrastructure

        public static FilePathProvider Instance { get; } = new();

        private FilePathProvider()
        {
        }

        #endregion
    }
}
