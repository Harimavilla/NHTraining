using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_16_project_1
{
    class Message
    {
        public static void PrintHello()
        {
            Console.WriteLine("Hello");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Message.PrintHello();
            Console.ReadLine();
        }
    }
}
