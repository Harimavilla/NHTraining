﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chandana_Library
{
    internal class Mathematics
    {
        int input;
        public void ReadData()
        {
            Console.WriteLine("Enter Number:");
            input = Convert.ToInt32(Console.ReadLine());

        }
        public int GetFactorial()
        {
            int fact = 1;
            for (int i = 1; i <= input; i++)
            {
                fact = fact * i;
            }
            return fact;

        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Mathematics obj = new Mathematics();
                obj.ReadData();
                Console.WriteLine(obj.GetFactorial());
                Console.ReadLine();

            }
        }
    }
}
