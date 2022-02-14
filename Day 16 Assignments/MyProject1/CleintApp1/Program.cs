using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PublicLibrary;




namespace CleintApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Mathematics m = new Mathematics();
            Console.WriteLine(m.Add(5,6));
            Console.WriteLine(m.Mul(5,6));

            Console.ReadLine();

        }
    }
}
