using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Else_IF
{
    public class Nested_IF
    {

        public void NestIf()
        {
            int a = 15, b = 25, c = 10;
            int largestNumber = 0;

            if (a>b)
            {
                Console.WriteLine($"Outer IF Block");

                if (a>c)
                {
                    Console.WriteLine($"Outer IF - Inner IF Block");
                    largestNumber= a;
                } else
                {
                    Console.WriteLine($"Outer IF - Inner ELSE Block");
                    largestNumber = c;
                }

            } else
            {
                Console.WriteLine($"The Largest Number is: {largestNumber}");
                Console.ReadKey();

            }
        }

        public void TernaryIF()
        {
            int a = 15, b = 25, c = 10;
            int LargestNumber = 0;

            Console.WriteLine($"a={a}, b ={b}, c={c}");

            LargestNumber = (a > b) ? ((a > c) ? (a) : (c)) : ((b > c) ? (b) : (c));

            Console.WriteLine($"The Largest Number is: {LargestNumber}");
            Console.ReadKey();
        }
    }
}
