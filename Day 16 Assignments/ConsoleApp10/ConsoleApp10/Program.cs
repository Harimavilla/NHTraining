using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partialApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Addition is "+ Maths.Add(2, 5));
            Console.WriteLine("Divison is " + Maths.Div(3, 4));
            Console.ReadLine();
        
        }
    }
}
namespace A1Library
{
    public static partial class Maths
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int sub(int a, int b)
        {
            return a + b;
        }
        public static int Sub(int a, int b)
        {
            return a - b;
        }
    }
}
namespace A1Library
{
    public static partial class Maths
    {
        
    }
}