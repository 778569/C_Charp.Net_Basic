using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    public class NumericData_Type
    {

        public void NumericDType() 
        {

            Int16 num1 = 123;
            Int32 num2 = 456;
            Int64 num3 = 789;

            Console.WriteLine($"Int16 Min Value:{Int16.MinValue} and Max Value:{Int16.MaxValue}");
            Console.WriteLine($"Int16 Size:{sizeof(Int16)} Byte");
            Console.WriteLine($"Int32 Min Value:{Int32.MinValue} and Max Value:{ Int32.MaxValue}");
            Console.WriteLine($"Int32 Size:{sizeof(Int32)} Byte");
            Console.WriteLine($"Int64 Min Value:{Int64.MinValue} and Max Value:{ Int64.MaxValue}");
            Console.WriteLine($"Int64 Size:{sizeof(Int64)} Byte");
            Console.ReadKey();


        }

        public void NumericDType2() 
        {

            
            short num1 = 123;
          
            int num2 = 456;

           
            long num3 = 789;
            Console.WriteLine($"short Min Value:{short.MinValue} and Max Value:{ short.MaxValue}");
            Console.WriteLine($"short Size:{sizeof(short)} Byte");
            Console.WriteLine($"int Min Value:{int.MinValue} and Max Value:{ int.MaxValue}");
            Console.WriteLine($"int Size:{sizeof(int)} Byte");
            Console.WriteLine($"long Min Value:{long.MinValue} and Max Value:{ long.MaxValue}");
            Console.WriteLine($"long Size:{sizeof(long)} Byte");
            Console.ReadKey();



        }

        public void NDType3()
        {
            
                ushort num1 = 123;
               
                uint num2 = 456;
                
                ulong num3 = 789;
                Console.WriteLine($"ushort Min Value:{ushort.MinValue} and Max Value:{ ushort.MaxValue}");
                Console.WriteLine($"short Size:{sizeof(ushort)} Byte");
                Console.WriteLine($"uint Min Value:{uint.MinValue} and Max Value:{ uint.MaxValue}");
                Console.WriteLine($"uint Size:{sizeof(uint)} Byte");
                Console.WriteLine($"ulong Min Value:{ulong.MinValue} and Max Value:{ ulong.MaxValue}");
                Console.WriteLine($"ulong Size:{sizeof(ulong)} Byte");
                Console.ReadKey();

        }

        public void NumericNumberswithDecimal()
        {
            Single a = 1.123f;
            Double b = 1.456;
            Decimal c = 1.789M;
            Console.WriteLine($"Single Size:{sizeof(Single)} Byte");
            Console.WriteLine($"Single Min Value:{Single.MinValue} and Max Value:{ Single.MaxValue}");
            Console.WriteLine($"Double Size:{sizeof(Double)} Byte");
            Console.WriteLine($"Double Min Value:{Double.MinValue} and Max Value:{ Double.MaxValue}");
            Console.WriteLine($"Decimal Size:{sizeof(Decimal)} Byte");
            Console.WriteLine($"Decimal Min Value:{Decimal.MinValue} and Max Value:{ Decimal.MaxValue}");
            Console.ReadKey();
        }

        public void UnderstandAccuracy()
        {
            float a = 1.78986380830029492956829698978655434342477f; 
            
            double b = 1.78986380830029492956829698978655434342477;
            //15 digits Maximum
            decimal c = 1.78986380830029492956829698978655434342477m;
            //29 digits Maximum
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.ReadKey();
        }

        public void UnderstandAccuracy2()
        {
            Stopwatch stopwatch1 = new Stopwatch();
            stopwatch1.Start();
            for (int i = 0; i <= 10000000; i++)
            {
                short s1 = 100;
                short s2 = 100;
                short s3 = 100;
            }
            stopwatch1.Stop();
            Console.WriteLine($"short took :{ stopwatch1.ElapsedMilliseconds}MS");
            Stopwatch stopwatch2 = new Stopwatch();
            stopwatch2.Start();
            for (int i = 0; i <= 10000000; i++)

            {
                decimal s1 = 100;
                decimal s2 = 100;
                decimal s3 = 100;
            }
            stopwatch2.Stop();
            Console.WriteLine($"decimal took :{ stopwatch2.ElapsedMilliseconds} MS");
            Console.ReadKey();
        }

        public void Size_of_PreDefined_Data_Types()
        {
            Console.WriteLine($"Size of Byte: {sizeof(byte)}");
            Console.WriteLine($"Size of Integer: {sizeof(int)}");
            Console.WriteLine($"Size of Character: {sizeof(char)}");
            Console.WriteLine($"Size of Float: {sizeof(float)}");
            Console.WriteLine($"Size of Long: {sizeof(long)}");
            Console.WriteLine($"Size of Double: {sizeof(double)}");
            Console.WriteLine($"Size of Bool: {sizeof(bool)}");
            Console.ReadKey();

        }

       
        public void Minimu_and_Maximum_Range_of_Values()
        {
            Console.WriteLine($"Byte => Minimum Range:{byte.MinValue}and Maximum Range:{ byte.MaxValue}");
            Console.WriteLine($"Integer => Minimum Range:{int.MinValue}and Maximum Range:{ int.MaxValue}");
            Console.WriteLine($"Float => Minimum Range:{float.MinValue}and Maximum Range:{ float.MaxValue}");
            Console.WriteLine($"Long => Minimum Range:{long.MinValue} and Maximum Range:{ long.MaxValue}");
            Console.WriteLine($"Double => Minimum Range:{ double.MinValue} and Maximum Range: { double.MaxValue}");
            Console.ReadKey();

        }

       
             public void Default_Values_of_built_in_Data_Types()
        {
            Console.WriteLine($"Default Value of Byte: {default(byte)}");
            Console.WriteLine($"Default Value of Integer:{ default(int)}");
            Console.WriteLine($"Default Value of Float:{ default(float)}");
            Console.WriteLine($"Default Value of Long:{ default(long)}");
            Console.WriteLine($"Default Value of Double:{ default(double)}");
            Console.WriteLine($"Default Value of Character:{ default(char)}");
            Console.WriteLine($"Default Value of Boolean:{ default(bool)}");
            Console.ReadKey();


        }

        

             public void Pointer_Type()
        {
            unsafe
            {
                // declare a variable
                int number = 10;
                // store variable number address location in pointer variable ptr
                int* ptr = &number;
                Console.WriteLine($"Value :{number}");
                Console.WriteLine($"Address :{(int)ptr}");
                Console.ReadKey();
            }
        }
    }
}
