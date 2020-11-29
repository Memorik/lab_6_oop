using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6
{
    abstract class AbstractHandler
    {
        public string path { get; set; }

        public AbstractHandler(string Path)
        {
            path = Path;
        }
        public abstract void CreateFile(string fileName, string text = "new file");
        public abstract void OpenFile(string fileName);
        public abstract void FileEdit(string fileName);
        public abstract void FileEdit(string fileName,string Path);
    }
}
