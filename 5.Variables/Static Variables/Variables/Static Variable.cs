using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    public class Static_Variable
    {

        static int x = 100; 
        int y = 200; // non static variable
        public void StaticVariable()
        {
            Console.WriteLine($"x value: {x}");
            Console.Read();
        }
    }
}
