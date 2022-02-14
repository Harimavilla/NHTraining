using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp._7
{
    public class IsPalendrome
    {
        private int temp;

        public void Check(int a)
        {
            int r = 0; temp = a;
            bool flag = false;
            while (a > 0)
            {
                int c = a % 10;
                a = a / 10;
                r = r * 10 + c;
            }
            if (temp == r)
            {
                Console.WriteLine(r + "its apalendrome");
            }
            else
            {
                Console.WriteLine((r + "its not a palendrome"));
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var X=new IsPalendrome();
            X.Check(123);
            Console.ReadLine();

        }
    }
}
