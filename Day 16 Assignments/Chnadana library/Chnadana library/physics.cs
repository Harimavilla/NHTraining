using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chnadana_library
{
    internal class physics
    {
        public int FinalVelocity(int u, int a, int t)
        {
            return u + a * t;
            var p = new physics();
            var v= p.FinalVelocity(u, a, t);
            Console.WriteLine(v);
            Console.ReadLine();
        }
    }
}
