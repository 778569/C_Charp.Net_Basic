using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Literals
{
    public class String_Literals
    {

        public void StringLiterals()
        {
            string str1 = "Dot Net Tutorials";
            string str2 = @"Dot Net Tutorials";
            string str3 = "Dot\nNet\tTutorials";
            string str4 = @"Dot\nNet\tTutorials";

            Console.WriteLine($"str1: {str1}");
            Console.WriteLine($"str2: {str2}");
            Console.WriteLine($"str3: {str3}");
            Console.WriteLine($"str4: {str4}");
            Console.ReadKey();

        }
    }
}
