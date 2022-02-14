using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace public_library
{
   public static class physics
    {
        public static int FinalVelocity(int u, int a, int t)
        {
            return u + a * t;
        }
    }
}
