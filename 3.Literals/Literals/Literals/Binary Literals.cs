using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Literals
{
    public class Binary_Literals
    {

        public void BinaryLiterals()
        {
            
            int Num1 = 0b100111101;
            int Num2 = 0b01000011;


            //int num3 = 0b100134; //Error here include 3 , 4

            Console.WriteLine($"Value of Num1 is: {Num1}");
            Console.WriteLine($"Value of Num2 is: {Num2}");
            Console.WriteLine($"Char value of Num1 is:{ Convert.ToChar(Num1)}");
            Console.WriteLine($"Char value of Num2 is:{ Convert.ToChar(Num2)}");
            Console.ReadKey();

        }
    }
}
