using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chnadanalibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int u = 5;
            int a = 2;
            int t = 3;
            {

                var p = new physics();
                var v = p.FinalVelocity(u, a, t);
                Console.WriteLine(v);
                Console.ReadLine();
            }
        }
    }
}
