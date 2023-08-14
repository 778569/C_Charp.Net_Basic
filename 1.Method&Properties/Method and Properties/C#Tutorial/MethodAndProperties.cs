using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace C_Tutorial
{
    public class MethodAndProperties
    {
        string name = "Kavinda";

       public void Method1()
        {
            Console.WriteLine(name);
            Console.WriteLine("Hello" + name);
            Console.WriteLine($"Hello {name}");
            Console.ReadKey();

       }


    public void Method2()
        {
            Console.WriteLine("Enter Your Nane");
            string? name = Console.ReadLine();
            Console.WriteLine($"hello {name}");
            Console.ReadKey();


        }

        public void Method3()
        {
            //How to read integer values

            Console.WriteLine("Enter two Numbers");
            int Number1 = Convert.ToInt32(Console.ReadLine()!);
            
            int Number2 = int.Parse(Console.ReadLine()!);


            int Result =  Number1 + Number2;

            Console.WriteLine($"The Sum is: {Result} ");

            //or

            Console.WriteLine($"The sum is {Number1+Number2}");

            Console.ReadKey();

        }

        public void Method4()
        {
            Console.WriteLine("Enter a Key");
            int var1 = Console.Read();
            Console.WriteLine($"ASCII Value of the Entered Key is:{ var1}");
            Console.WriteLine("Enter Another Key");
            ConsoleKeyInfo var2 = Console.ReadKey();
            Console.WriteLine($"\nEntered Key: {var2.Key} KeyChar:{ var2.KeyChar} ASCII: { (int)var2.KeyChar}");
            Console.WriteLine("Press Any Key to Terminate");
            Console.ReadKey();
        }

        public void Method5()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Title = "Understanding Console Class";
            Console.WriteLine("BackgroundColor: Blue");
            Console.WriteLine("ForegroundColor: White");
            Console.WriteLine("Title: Understanding Console Class");
            Console.Beep();
            Console.ReadKey();
        }

        public void Example01()
        {
            Console.WriteLine("Enter Employe Details");

            Console.WriteLine("Enter Employe ID");
            int EmployeeID = Convert.ToInt32(Console.ReadLine()!);

            Console.WriteLine("Enter Employee Name");
            string? Name = Console.ReadLine();

            Console.WriteLine("Enter Employee Salary");
            int Salary = Convert.ToInt32(Console.ReadLine()!);

            Console.WriteLine("Enter Empoyee Address");
            string? Address = Console.ReadLine();

            Console.WriteLine("Enter Employee Department");
            string? Department = Console.ReadLine();

            //Display Employee Details

            Console.WriteLine("\nEnterd Employee Details are as Follows: ");

            Console.WriteLine($"Employee ID Is : {EmployeeID}");
            Console.WriteLine($"Employee Name IS : {Name}");
            Console.WriteLine($"Employee Salary Is : {Salary}");
            Console.WriteLine($"Employee Addrerss Is : {Address}");
            Console.WriteLine($"Employee Department Is : {Department}");

            Console.ReadKey();

        }

        public void Example02()
        {
            Console.WriteLine("Enter Student Details");
            Console.WriteLine("Enter Registration Number");

            int RNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name");
            string? Name = Console.ReadLine();

            Console.WriteLine("Enter Marks of three Subjects:");

            Console.WriteLine("Subject1");
            int Mark1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Subject2");
            int Mark2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Subject3");
            int Mark3 = Convert.ToInt32(Console.ReadLine());

            int TotalMarks = Mark1 + Mark2 + Mark3;
            int AverageMark = TotalMarks / 3;
            
            Console.WriteLine("\nStudent Details are as Follows:");
            Console.WriteLine($"Registration Number: {RNumber}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Total Marks : {TotalMarks}");
            Console.WriteLine($"Average Mark: {AverageMark}");
            Console.ReadKey();

        }


    }
}
