using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Table
    {
        public void M_table(int a)
        {
            int i = 1;
            while (i < 11)
            {
            
            {
                Console.WriteLine($"{a}X{i}={a * i}");
                i++;
            }
        }
    }
                   
        

    }
    internal class Program
    {
        static void Main(string[] args)
        {
        var r = new Table();
        r.M_table(7);
        Console.ReadLine();
        }
    }
}

