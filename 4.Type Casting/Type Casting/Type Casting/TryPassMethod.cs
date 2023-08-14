using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
namespace Type_Casting
{
    public class TryPassMethod
    {


        /*first conversion is successful and hence it will return true
        and will store the converted value 100 in the I1 variable.In the second conversion, the conversion failed 
        and hence it will not store anything in the I2 variable and this time it will return false.*/

        public void TryPass()
        {
            string str1 = "100";
            bool IsConverted1 = int.TryParse(str1, out int I1);
            if (IsConverted1)
            {
                Console.WriteLine($"Original String value: {str1} and Converted int value: {I1}");
            }
            else
            {
                Console.WriteLine($"Try Parse Failed to Convert {str1} to integer");
            }
            string str2 = "Hello";
            bool IsConverted2 = int.TryParse(str2, out int I2);
            if (IsConverted2)
            {
                Console.WriteLine($"Original String value: {str2} and Converted int value: {I2}");
            }
            else
            {
                Console.WriteLine($"Try Parse Failed to Convert {str2} to integer");
            }
            Console.ReadKey();
        }


    }
}
