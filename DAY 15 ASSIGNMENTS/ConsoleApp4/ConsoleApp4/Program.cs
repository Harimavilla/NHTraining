using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
       

        static void Main(string[] args)
        {
            Console.WriteLine(File.ReadAllText("D:\\mydata files\\Hello.text\\file.txt"));
            Console.WriteLine("File ReadLines");
            Console.ReadLine();

        }
    }
}
