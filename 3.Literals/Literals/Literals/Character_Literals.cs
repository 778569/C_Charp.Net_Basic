using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Literals
{
    public class Character_Literals
    {

        public void CharLiterals()
        {
            //Character literal using single quote
            char ch1 = 'A';
            Console.WriteLine("Single Quote: " + ch1);

            //Character literal using Unicode representation
            char ch2 = '\u0041';
            Console.WriteLine("Unicode: " + ch2);

            //Character literal using Escape character
            Console.WriteLine("Escape: Hello\nDotNet\tTutorials");
            Console.ReadKey();


        }
    }
}
