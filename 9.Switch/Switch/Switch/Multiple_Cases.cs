using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    public class Multiple_Cases
    {
      

        public void Switch_multiple_case()
        {
            string str = "C#";
            switch (str)
            {
                case "C#":
                case "Java":
                case "C":
                    Console.WriteLine("It’s a Programming Langauge");
                    break;
                case "MSSQL":
                case "MySQL":
                case "Oracle":
                    Console.WriteLine("It’s a Database");
                    break;
                case "MVC":
                case "WEB API":
                    Console.WriteLine("It’s a Framework");
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
            Console.ReadKey();
        }
       
    }
}
