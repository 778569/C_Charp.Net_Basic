using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type_Casting
{
    public class Casting_Data_Loss
    {
        public void CastingDataLoss()
        {
            int IntNum1 = 100;
            byte ByteNum1 = (byte)IntNum1;
            Console.WriteLine($"Original Value:{IntNum1} and Converted Value:{ByteNum1}");

            // IN here no data loss bcz byte range goes to 0-244 result is ByteNum1 = 100


            int IntNum2 = 600;
            byte ByteNum2 = (byte)IntNum2;
            Console.WriteLine($"Original Value:{IntNum1} and Converted Value:{ByteNum2}");

            // IN here have data loss bcz byte range goes to 0-244 result is ByteNum2 = 244
        }
    }
}
