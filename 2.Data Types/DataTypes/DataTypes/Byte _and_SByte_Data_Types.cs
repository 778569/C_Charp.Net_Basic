using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    public class Byte__and_SByte_Data_Types
    {
        public void byte_sbyte()
        {
            byte b1 = 66;

            Console.WriteLine($"Decimal: {b1}");
            Console.WriteLine($"ASCII Equivalent Character of {b1} is { (char)b1}");

            Console.WriteLine($"Byte Min Value:{sbyte.MinValue} and Max Value:{ sbyte.MaxValue}");
            Console.WriteLine($"Byte Size:{sizeof(sbyte)} Byte");

            sbyte sb1 = 66;
            sbyte sb2 = -100;

            Console.WriteLine($"\nDecimal: {sb1}");
            Console.WriteLine($"ASCII Equivalent Character of {sb1} is { (char)sb1}");
            Console.WriteLine($"ASCII Equivalent Character of {sb2} is{ (char)sb2}");
            Console.WriteLine($"SByte Min Value:{sbyte.MinValue} and Max Value:{ sbyte.MaxValue}");
            Console.WriteLine($"SByte Size:{sizeof(sbyte)} Byte");
            Console.ReadKey();

        }
    }
}
