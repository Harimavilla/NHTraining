using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_or_not
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 41, i;
            for (i = 2; i < n; i++)
            {
                if (n % i == 0)
                    break;
            }

            if (i == n)
                Console.WriteLine("PRIME");
            else
                Console.WriteLine("NOT PRIME");
            Console.ReadLine();



        }
    }
}

