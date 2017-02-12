using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void GetdFile(string path) 
        {
            Stack<string> directory = new Stack<string>(); 

            directory.Push(path); 
            while (directory.Count > 0) 
            {
                DirectoryInfo current = new DirectoryInfo(directory.Pop()); 
                
                DirectoryInfo[] dir = current.GetDirectories(); 
                FileInfo[] files = current.GetFiles(); 
                Console.WriteLine(current); 
                Console.WriteLine("Files:" + current.GetFiles().Length); 
                foreach (FileInfo file in files) 
                {
                    Console.WriteLine("---" + file.Name);
                }
                Console.WriteLine("Directories:" + current.GetDirectories().Length); 
                foreach (DirectoryInfo d in dir)
                {
                    directory.Push(d.FullName); 

                }
            }

        }
        static void Main(string[] args)
        {
            GetdFile(@"C:\Users\Amanzhol\Source\Repos");
            Console.ReadKey();
        }
    }
}