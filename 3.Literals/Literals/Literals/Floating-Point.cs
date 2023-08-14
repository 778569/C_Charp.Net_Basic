using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Literals
{
    public class Floating_Point
    {


        public void FloatingPointLiterals()
        {
            //Double Literal
            double a = 10.15; //By Default Floating Point Literal is double

            //Float Literal
            float b = 100.72F; //Suffix with F

            //Double Literal
            double c = 1.45D; //Suffix with D

            //Decimal Literal
            decimal d = 1.44M; //Suffix with M


            Console.WriteLine($"Double Literal: {a}");
            Console.WriteLine($"Float Literal: {b}");
            Console.WriteLine($"Double Literal: {c}");
            Console.WriteLine($"Decimal Literal: {d}");
            Console.ReadKey();

        }

    }
}
