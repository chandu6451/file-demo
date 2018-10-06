using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename;

            Console.Write("Enter File Name with full path : ");
            filename = Console.ReadLine();

            FileInfo file = new FileInfo(filename);

            //FileInfo file = new FileInfo(@"D:\Data\Links.docx");

            if (file.Exists)
            {
                Console.WriteLine("File Name : " + file.Name);
                Console.WriteLine("Creation Time : " + file.CreationTime);
                Console.WriteLine("Directory : " + file.Directory.Name);
                Console.WriteLine("Directory Name : " + file.DirectoryName);
                Console.WriteLine("Extension : " + file.Extension);
                Console.WriteLine("Full Name : " + file.FullName);
                Console.WriteLine("Is Read Only : " + file.IsReadOnly);
                Console.WriteLine("Last Access Time : " + file.LastAccessTime);
                Console.WriteLine("Last Write Time : " + file.LastWriteTime);
                Console.WriteLine("Length : " + file.Length);
            }
            else
            {
                Console.WriteLine("File not found");
            }

            Console.ReadKey();
        }
    }
}
