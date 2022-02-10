using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{


    class SimpleInterest
    {
        //Author: harichandana
        //Purpose Creating Class By using Normal Properties and Auto-Implemented Properties
        private int amount;
        private int annualRate;
        private int time;
        private int interest;
        //Normal Properties
        public int Principleamount
        {
            set
            {
               amount = value;
            }
        }
        public int AnnualRate
        {
            set
            {
                annualRate = value;
            }
        }
        public int Time
        {
            set
            {
                time = value;
            }
        }
        public int Interest
        {
            get
            {
                return interest = amount * annualRate * time / 100;
            }
        }
        static void Main(string[] args)
        {
            SimpleInterest s = new SimpleInterest();
            s.annualRate = 1300;
            s.time = 1;
            s.amount = 10000;
            Console.WriteLine(s.Interest);
            Console.ReadLine();


        }
    }
}


    
            
        
    






    
