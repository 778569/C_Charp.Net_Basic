using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    public class Increment_Operators
    {

        public void IncrementOperators()
        {
            int x = 10;
            // Result1 is assigned 10 only,
            // x is not updated yet
            int Result1 = x++;
            //x becomes 11 now
            Console.WriteLine("x is {0} and Result1 is {1}", x, Result1);
            // Pre-Increment 
            int y = 10;
            int Result2 = ++y;
            //y and Result2 have same values = 11
            Console.WriteLine("y is {0} and Result2 is {1}", y, Result2);
            Console.ReadKey();
        }
        public void DecrementOperators()
        {
            int x = 10;

            // Result1 is assigned 10 only,
            // x is not yet updated
            int Result1 = x--;

            //x becomes 9 now
            Console.WriteLine("x is {0} and Result1 is {1}", x, Result1);

            // Pre-Decrement 

            int y = 10;
            int Result2 = --y;

            //y and Result2 have same values i.e. 9
            Console.WriteLine("y is {0} and Result2 is {1}", y, Result2);
            Console.ReadKey();
        }

    }
}
