using System;
using System.Security.Cryptography.X509Certificates;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите путь каталога: ");
            string path = Console.ReadLine();
            TxtType txtType = new TxtType(path);
            Start(txtType);
            void Start(AbstractHandler Type)
            {
                Console.WriteLine("Выберете действие: 1)Create File 2)Open File 3)File editing");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите имя файла: ");
                string fileName = Console.ReadLine();
                switch (num)
                {
                    case 1:
                    {
                        Console.WriteLine("Введите текст:");
                        string text = Console.ReadLine();
                        if (text != String.Empty)
                            Type.CreateFile(fileName, text);
                        else
                        {
                            Type.CreateFile(fileName);
                        }

                        break;

                    }
                    case 2:
                    {
                        Type.OpenFile(fileName);
                        break;

                    }
                    case 3:
                    {
                        Console.WriteLine("1)Delete 2)Move File");
                        int choice = int.Parse(Console.ReadLine());
                        if (choice == 1) 
                        {
                            Type.FileEdit(fileName);
                        }
                        else if (choice == 2)
                        {
                            Console.WriteLine("path:");
                            string mpath = Console.ReadLine();
                            Type.FileEdit(fileName, mpath);
                        }
                        break;
                    }
                }
            }
        }
    }
}
