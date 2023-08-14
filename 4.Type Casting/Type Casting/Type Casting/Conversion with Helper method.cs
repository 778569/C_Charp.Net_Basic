using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type_Casting
{
    public class Conversion_with_Helper_method
    {

       public void HelperMethod1()
        {
            string str = "100";
            //int i1 = (int)str; Here Shown error " Cant convert 'string' to 'int'" So we can use helper method

            int i1 = Convert.ToInt32(str);
            //Here helper Method id  Convert.ToInt32
            Console.ReadKey();

            double d = 123.45;
            int i2 = Convert.ToInt32(d);

            float f = 45.678F;
            string str2 = Convert.ToString(f);


            Console.WriteLine($"Original value str: {str} and Converted Value i1:{i1}");
            Console.WriteLine($"Original value d: {d} and Converted Value i2:{i2}");
            Console.WriteLine($"Original value f: {f} and Converted Value str2:{str2}");
            Console.ReadKey();
        }

        public void HelperMethod2()
        {
            string str = "Hello";
            //int i1 = Convert.ToInt32(str); Converting string to Integer - Exception "Input String was not correct format"

            // For the we use Parse()
            //Console.WriteLine($"Original value str: {str} and Converted Value i1:{i1}");

            //Console.ReadKey();

            string str1 = "100";
            //Converting string to int type
            int i = int.Parse(str1);

            int t = Convert.ToInt32(str1);
            Console.WriteLine($"Original String value: {str1} and Converted int value: {i}");

            Console.WriteLine($"Original String value: {str1} and Converted int value: {t}");
            string str2 = "TRUE";
            //Converting string to boolean type
            bool b = bool.Parse(str2);

            bool bb = Convert.ToBoolean(str2);

            Console.WriteLine($"Original String value: {str2} and Converted bool value: {b}");

            Console.WriteLine($"Original String value: {str2} and Converted bool value: {bb}");
            Console.ReadKey();

        }
    }
}
