using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    public class CharDataType
    {

        public void CharDType()
        {
            char ch = 'B';
            Console.WriteLine($"Char: {ch}");
            Console.WriteLine($"Equivalent Number: {(byte)ch}");
            Console.WriteLine($"Char Minimum: {(int)char.MinValue} and Maximum: { (int)char.MaxValue}");
            Console.WriteLine($"Char Size: {sizeof(char)} Byte");
            Console.ReadKey();
        }
    }
}
