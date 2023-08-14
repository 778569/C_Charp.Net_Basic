using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type_Casting
{
    public class Explicit_Type_Casting
    {
        public void ExplicitTypeCasting()
        {
            double numDouble = 1.23;
            //int numInt = numDouble;
            //Shown error - "Cannot implicitly convert type ‘double’ to ‘int’. An explicit conversion exists (are you missing a cast?"

            int numInt = (int)numDouble;
            Console.WriteLine("Original double Value: " + numDouble);
            
            Console.WriteLine("Converted int Value: " + numInt);
            //in here result is 1
            Console.ReadKey();
        }
    }
}
