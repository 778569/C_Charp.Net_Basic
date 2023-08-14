using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Literals
{
    public class Integer_Literals
    {
        public void IntegerLiterals()
        {
            // Decimal literal, Allowed Digits: 0 to 9 and No suffix is required
            int a = 101;

            // Hexa-Decimal Literal , Allowed Digits: 0 to 9 and Character a to f
            int c = 0x123f; //Prefix with 0x, and suffix with f

            //Binary literal
            //Allowed Digits: 0 to 1
            int d = 0b1111; // //Prefix with 0b

            Console.WriteLine($"Decimal Literal: {a}");
            Console.WriteLine($"Hexa-Decimal Literal: {c}");
            Console.WriteLine($"Binary Literal: {d}");
            Console.ReadKey();


        }

        public void IntegerLiterals1()
        {
            int a = 1000; //Integer
            uint b = 1000U; //Unsigned Integer
            long c = 1000L; //Long
            ulong d = 1000UL; //Unsigned Long

            Console.WriteLine($"Integer Literal: {a}");
            Console.WriteLine($"Unsigned Integer Literal: {b}");
            Console.WriteLine($"Long Literal: {c}");
            Console.WriteLine($"Unsigned Long Literal: {d}");
            Console.ReadKey();

        }
    }
}
