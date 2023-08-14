using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type_Casting
{
    public class Implicit_Type_Casting
    {

        public void ImplicitTypeCasting()
        {
            int numInt = 1500;

            Type numIntType = typeof(int);

            Type numIntType1 = numInt.GetType();

            double numDouble = numInt;

            Type numDoubleType = numDouble.GetType();


            Console.WriteLine($"numInt value: {numInt}");
            Console.WriteLine($"numInt Type: {numIntType}");
            Console.WriteLine($"Int Size: {sizeof(int)} Bytes");
         
            Console.WriteLine($"numDouble value: {numDouble}");
            Console.WriteLine($"numDouble Type: {numDoubleType}");
            Console.WriteLine($"double Size: {sizeof(double)} Bytes");
            Console.ReadKey();
        }
    }
}
