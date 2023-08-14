using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    public class Assignment_Operators
    {

        public void AssignmentOperators()
        {
            int x = 15;
            x += 10;  //It means x = x + 10 //// 15 + 10 = 25
            Console.WriteLine($"Add Assignment Operator: {x}");

            // initialize variable x again
            x = 20;
            x -= 5;  //It means x = x - 5 //// 20 - 5 = 15
            Console.WriteLine($"Subtract Assignment Operator: {x}");

            
            x = 15;
            x *= 5; //It means x = x * 5  //// 15 * 5 = 75
            Console.WriteLine($"Multiply Assignment Operator: {x}");

            
            x = 25;
            x /= 5; //It means x = x / 5 //// 25 / 5 = 5
            Console.WriteLine($"Division Assignment Operator: {x}");

            
            x = 25;
            x %= 5; //It means x = x % 5 i//// 25 % 5 = 0
            Console.WriteLine($"Modulo Assignment Operator: {x}");

        }
    }
}
