using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Else_IF
{
    public class IF_and_Else
    {

        public void IFandElse()
        {
            Console.WriteLine("Enter a Number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is an Even Number");
            }
            else
            {
                Console.WriteLine($"{number} is an Odd Number");
            }
            Console.ReadKey();
        }

        public void IFandElseWithoutBraces()
        {
            Console.WriteLine("Enter a Number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            
                Console.WriteLine($"{number} is an Even Number");
            
            else
            
                Console.WriteLine($"{number} is an Odd Number");
            
            Console.ReadKey();
        }

        public void IFandElse2Statement()
        {
            //int number = 10;
            //if (number == 10)
            //    Console.WriteLine("Hi");
            //    Console.WriteLine("Hello");
            //else
            //    Console.WriteLine("Bye");

            //Console.ReadKey();


            int number = 10;
            if (number == 10)
            {
                Console.WriteLine("Hi");
                Console.WriteLine("Hello");
            }
                
            else
                Console.WriteLine("Bye");

            Console.ReadKey();
        }

    }
}
