using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     sealed class Police
    {
        public static int Helpline = 100;

        public string Getsecret()
        {
            return "007";
        }
        
        
            internal class program
            {
                static void Main(string[]args)
                {
               Police P = new Police();
                  
                Console.WriteLine(P.Getsecret());
                Console.WriteLine(Police.Helpline);
                Console.ReadLine();
                    
                }
            }
        }
        

        }
    

