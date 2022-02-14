using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chandanaLibrary

{
    internal class mathematics
    {
        public class Mathematics
        {
            int n;
            public void ReadData()
            {
                Console.WriteLine("Enter number:");
                n = Convert.ToInt32(Console.ReadLine());
            }
            public int Fact()
            {
                int fact = 1;
                for (int i = 0; i <= n; i++)
                {
                    fact = fact * i;
                }
                return fact;
                Console.ReadLine();
            }
        }
    }
}
