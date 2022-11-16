using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaterInConsoleDotNetFramework
{
    class Calculator
    {
        static void Main(string[] args)
        {
            string value;
            do
            {
                int ans;
                Console.Write("Enter first number:");
                int value1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter second number:");
                int value2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter symbol(/,+,-,*):");
                string symbol = Console.ReadLine();

                switch (symbol)
                {
                    case "+":
                        ans = value1 + value2;
                        Console.WriteLine("Addition:" + ans);
                        break;
                    case "-":
                        ans = value1 - value2;
                        Console.WriteLine("Subtraction:" + ans);
                        break;
                    case "*":
                        ans = value1 * value2;
                        Console.WriteLine("Multiplication:" + ans);
                        break;
                    case "/":
                        ans = value1 / value2;
                        Console.WriteLine("Division:" + ans);
                        break;
                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }
                Console.ReadLine();
                Console.Write("Do you want to continue(y/n):");
                value = Console.ReadLine();
            }
            while (value == "y");
        }
    }
}
