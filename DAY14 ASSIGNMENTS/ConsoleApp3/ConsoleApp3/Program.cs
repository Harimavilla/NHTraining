using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
   class SimpleInterest
    {
        //Author: harichandana
        //Purpose Creating Class By using Normal Properties and Auto-Implemented Properties
        private int principleamount;
        private int annualRate;
        private int time;
        private int interest;
        //Auto-Implemented Properties
        public int AutoImplementedInterest
        {
            get
            {
                return interest = principleamount * annualRate * time / 100;
            }

        }
        internal class Program
        {
            static void Main(string[] args)
            {
                SimpleInterest s = new SimpleInterest();
               
                s.principleamount = 10000;
                s.annualRate = 4;
                s.time = 2;
                Console.WriteLine(s.AutoImplementedInterest);
                Console.ReadLine();
            }
        }
    }
}
       
