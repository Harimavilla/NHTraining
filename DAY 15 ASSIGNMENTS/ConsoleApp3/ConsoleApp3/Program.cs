using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {

           
    {
 
            {
                //File.Create("D:\\mydata files\\Hello.text");
                File.WriteAllText(" D:\\mydata files\\Hello.text", "chandana");
                Console.WriteLine("File done");

                StreamWriter sr = new StreamWriter(" D:\\mydata files\\Hello.txt", true);




                sr.WriteLine(" this");
                sr.WriteLine(" abc");
                sr.WriteLine("def ");
                sr.WriteLine("ghi");
                sr.Close();

                Console.ReadLine();



            }
        }
    }
 

 





        }
    }

