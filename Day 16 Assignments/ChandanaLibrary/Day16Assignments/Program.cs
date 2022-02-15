using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChandanaLibrary;

namespace Day16Assignments
{
    public class Program
    {
        static void Main(string[] args)
        {          
                
                
                
                
                
                
                
                
                /*physics p = new physics
                 * Console.WriteLine(p.FinalVelocity(5, 6, 7));
            chemistry c = new chemistry();
            Console.WriteLine(c.GetBenzene());
            Console.WriteLine(c.GetWater());
            Console.WriteLine(c.GetMethane());*/
            Mathematics mathematics = new Mathematics();
            Console.WriteLine(mathematics.Add(5, 2));
            Console.WriteLine(mathematics.Mul(3, 5));
            Console.WriteLine(mathematics.sub(5,2));
            Console.WriteLine(mathematics.div(8,6));
            Console.ReadLine();

                
        }
    }
}
