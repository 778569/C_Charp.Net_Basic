using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    public class switchWithIf
    {
        public void switch_With_If()
        {

            string category;
            string topic = "Inheritance";

            if (topic.Equals("Introduction to C#") ||
                topic.Equals("Variables") ||
                topic.Equals("Data Types")
                
                )
            {
                category = "Basic";
            } else if (topic.Equals("Loops") ||
                topic.Equals("If ELSE Statements") ||
                topic.Equals("Jump Statements"))
            {
                category = "Control Flow";
            }
            else if (topic.Equals("Inheritance") ||
               topic.Equals("Polymorphism") ||
               topic.Equals("Abstraction") ||
               topic.Equals("Encapsulation"))
            {
                category = "OOPS Concept";
            }
            else
            {
                category = "Invalid";
            }
            Console.Write($"{topic} Category is {category}");
            Console.ReadKey();

        }


       public void Using_switch()
        {
            string category;
            string topic = "Inheritance";
            ////Using switch
            ///

            switch (topic)
            {
                case "Introduction to C#":
                case "Variables":
                case "Data Types":
                    category = "Basic";
                    break;

                case "Loops":
                case "If ELSE Statements":
                case "Jump Statements":
                    category = "Control Flow";
                    break;

                case "Inheritance":
                case "Polymorphism":
                case "Abstraction":
                case "Encapsulation":
                    category = "OOPS Concept";
                    break;

                // default case 
                default:
                    category = "Invalid";
                    break;

            }

            Console.Write($"{topic} Category is {category}");
            Console.ReadKey();
        }
}
}
