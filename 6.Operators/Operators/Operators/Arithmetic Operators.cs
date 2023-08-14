using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    public class Arithmetic_Operators
    {
        public void ArithmeticOperatorsWithVaeriale()
        {
            int Result;
            int Num1 = 20, Num2 = 10;

            // Addition Operation
            Result = (Num1 + Num2);
            Console.WriteLine($"Addition Operator: {Result}");

            // Subtraction Operation
            Result = (Num1 - Num2);
            Console.WriteLine($"Subtraction Operator: {Result}");

            // Multiplication Operation
            Result = (Num1 * Num2);
            Console.WriteLine($"Multiplication Operator: {Result}");

            // Division Operation
            Result = (Num1 / Num2);
            Console.WriteLine($"Division Operator: {Result}");

            // Modulo Operation
            Result = (Num1 % Num2);
            Console.WriteLine($"Module Operator: {Result}");
            
            Console.ReadKey();
        }

        public void ArithmeticOperatorsWithValues()
        {
            int Result;
            
            // Addition Operation
            Result = 20 + 10;
            Console.WriteLine($"Addition Operator: {Result}");

            // Subtraction Operation
            Result = 20 - 10;
            Console.WriteLine($"Subtraction Operator: {Result}");

            // Multiplication Operation
            Result = 20 * 10;
            Console.WriteLine($"Multiplication Operator: {Result}");

            // Division Operation
            Result = 20 / 10;
            Console.WriteLine($"Division Operator: {Result}");

            // Modulo Operation
            Result = 20 % 10;
            Console.WriteLine($"Module Operator: {Result}");

            Console.ReadKey();
        }
    }
}
