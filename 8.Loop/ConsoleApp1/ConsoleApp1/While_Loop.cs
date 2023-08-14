using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class While_Loop
    {
        public void whileLoop()
        {
            int x = 1;

            while (x<=5)
            {
                Console.WriteLine($"Value of X : {x}");
                x++;
            }
            Console.ReadKey();
        }

        public void LoopExample01()
        {
            int i = 2;
            int n = 0;

            Console.WriteLine("Enter a Number : ");
            n = Convert.ToInt32(Console.ReadLine());

            while ( i<= n)
            {
                
                Console.WriteLine($"{i}");
                i = i + 2;
                //i++;    
            }

            Console.ReadKey();
        }
    }
}
