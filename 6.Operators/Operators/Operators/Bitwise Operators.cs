using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    public class Bitwise_Operators
    {

        public void BitwiseOperators() 
        {

            int a = 12, b = 25, Result;

            // Bitwise AND Operator
            Result = a & b;
            Console.WriteLine($"Bitwise AND: {Result}");

            // Bitwise OR Operator
            Result = a | b;
            Console.WriteLine($"Bitwise OR: {Result}");

            // Bitwise XOR Operator
            Result = a ^ b;
            Console.WriteLine($"Bitwise XOR: {Result}");

            Console.ReadKey();

        }

        public void BitwiseOperatorsBool()
        {
            bool a = true, b = false, Result;


            // Bitwise AND Operator
            Result = a & b;
            Console.WriteLine($"Bitwise AND: {Result}");

            // Bitwise OR Operator
            Result = a | b;
            Console.WriteLine($"Bitwise OR: {Result}");

            // Bitwise XOR Operator
            Result = a ^ b;
            Console.WriteLine($"Bitwise XOR: {Result}");

            Console.ReadKey();
        }


        }
}
