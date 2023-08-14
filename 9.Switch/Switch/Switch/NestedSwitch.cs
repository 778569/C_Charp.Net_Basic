using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    public class NestedSwitch
    {
        public void Nested_Switch()
        {
            Console.Write("Enter a Number Between 1 and 3:");
            int number = Convert.ToInt32(Console.ReadLine());

            switch (number)
            {

                case 1:
                    Console.WriteLine("You Entered One");
                    Console.Write("Enter Color Code (R/G/B): ");
                    char color = Convert.ToChar(Console.ReadLine());

                    switch (Char.ToUpper(color))
                    {
                        case 'R':
                            Console.WriteLine("You have Selected Red Color");
                         break;
                        case 'G':
                            Console.WriteLine("You have Selected Green Color");
                            break;
                        case 'B':
                            Console.WriteLine("You have Selected Blue Color");
                            break;
                        default:
                            Console.WriteLine($"You Have Enter Invalid Color Code: {Char.ToUpper(color)}");
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("You Entered Two");
                    break;
                case 3:
                    Console.WriteLine("You Entered Three");
                    break;
                default:
                    Console.WriteLine("Invalid Number");
                    break;

            }
            Console.ReadLine();
        }
    }
}
