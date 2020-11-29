using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lab6
{
    class TxtType : AbstractHandler
    {
        public TxtType(string path) : base(path)
        {

        }

        public override void CreateFile(string fileName, string text = "new file")
        {

            using (FileStream fs = File.Create($"{path}\\{fileName}.txt"))
            {
                byte[] info = new UTF8Encoding(true).GetBytes(text);
                fs.Write(info, 0, info.Length);
            }
        }

        public override void OpenFile(string fileName)
        {
            using (FileStream fs = File.Open($"{path}\\{fileName}.txt", FileMode.Open))
            {
                byte[] b = new byte[1024];
                UTF8Encoding temp = new UTF8Encoding(true);
                Console.WriteLine($"Name: {fs.Name}, Type: {Path.GetExtension(fs.Name)}");
                while (fs.Read(b, 0, b.Length) > 0)
                {
                    Console.WriteLine(temp.GetString(b));
                }

            }
        }

        public override void FileEdit(string fileName)
        {

            File.Delete($"{path}\\{fileName}.txt");
        }

        public override void FileEdit(string fileName, string Path)
        {
            File.Move($"{path}\\{fileName}.txt", Path);
        }
    }
}
