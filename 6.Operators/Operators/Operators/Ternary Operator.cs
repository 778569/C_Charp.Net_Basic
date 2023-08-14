using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    public class Ternary_Operator
    {

        public void TernaryOperator()
        {
            int a = 20, b = 10, res;
            res = ((a > b) ? a : b);
            Console.WriteLine("Result = " + res);
            Console.ReadKey();
        }
    }
}
