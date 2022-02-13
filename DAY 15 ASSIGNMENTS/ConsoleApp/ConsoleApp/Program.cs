using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            File.Create("D:\\mydata files\\file.txt");
                Console.WriteLine("File is create");
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
