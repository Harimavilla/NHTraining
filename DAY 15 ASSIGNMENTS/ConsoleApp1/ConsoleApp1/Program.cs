using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            File.Copy(" D:\\NB Trainings\\Hello\\txt File.txt","D:\\NB Trainings\\Hello\\txt File.txt");

            Console.WriteLine("File is Copied");
           
            Console.ReadLine();


        }
    }
}
