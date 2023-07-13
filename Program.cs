using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int marks1, marks2;
            Console.WriteLine("Enter First Number");
            marks1 = int.Parse(Console.ReadLine());
            /*Console.WriteLine("Enter Second Number");
            marks2 = int.Parse(Console.ReadLine());*/
            if (marks1 >60)
            {
                Console.WriteLine("Enter Second Number");
                marks2 = int.Parse(Console.ReadLine());

                if ( marks2 > 55)
                {
                    Console.WriteLine("Selected");
                }
                else if(marks2 <55)
                {
                    Console.WriteLine(" fail");
                }

            }
            else  
            {
                Console.WriteLine("fail in pre");
            }
            Console.ReadKey();
        }
    }
}
