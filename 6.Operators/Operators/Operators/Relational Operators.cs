using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    public class Relational_Operators
    {

        public void RelationalOperators()
        {
            bool Result;
            int Num1 = 5, Num2 = 10;

            // Equal to Operator
            Result = (Num1 == Num2);
            Console.WriteLine("Equal (=) to Operator: " + Result);

            // Greater than Operator
            Result = (Num1 > Num2);
            Console.WriteLine("Greater (<) than Operator: " + Result);

            // Less than Operator
            Result = (Num1 < Num2);
            Console.WriteLine("Less than (>) Operator: " + Result);

            // Greater than Equal to Operator
            Result = (Num1 >= Num2);
            Console.WriteLine("Greater than or Equal to (>=) Operator: " + Result);

            // Less than Equal to Operator
            Result = (Num1 <= Num2);
            Console.WriteLine("Lesser than or Equal to (<=) Operator: " + Result);

            // Not Equal To Operator
            Result = (Num1 != Num2);
            Console.WriteLine("Not Equal to (!=) Operator: " + Result);

            Console.ReadKey();
        }
    }
}
