using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Else_IF
{
    public class IF_Statement
    {
        
        public void IfStatement()
        {
            int number;

            Console.WriteLine("Enterm Number");

            number = Convert.ToInt32(Console.ReadLine());

            if (number > 10)
            {
                Console.WriteLine($"{number} Greter than 10");
                Console.WriteLine("End of if block");

            }

            Console.WriteLine("End of Main Method");
            Console.ReadKey();
        }

        public void IfStatementWithOutBraces()
        {

            int number;
            Console.WriteLine("Enter Number: ");
            number = Convert.ToInt32(Console.ReadLine());
            if(number > 10)
                Console.WriteLine($"{number} ism greater than 10");
            Console.WriteLine("End of Main Method");
            Console.ReadKey();

        }

    }
}
