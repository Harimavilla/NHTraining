using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            File.Create(" D:\\NB Trainings\\score.txt"," D:\\NB Trainings\\score.txt");
            Console.WriteLine("File is created");
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
