using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2OfDotNet
{
    class Questionn2
    {
        public static void NullException()
        {
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine("Null Expression Exception");
            string str = null;
            //it will show null exception
            try
            {
                if (str.Length == 0)
                {
                    Console.WriteLine(str);
                }
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e);
            }
            Console.Read();
        }

        public static void DevideByZero()
        {
            Console.WriteLine("DevideByZero Exception");
            int number1 = 3000;
            int number2 = 0;
            try
            {
                double ans = (number1 / number2);
                Console.WriteLine(ans);         //it will show infinite exception
            }
            catch (ArithmeticException op)
            {
                Console.WriteLine(op);
            }
        }

        public static void Multiply()
        {
            int a = 5;
            int b = 0;
            int ans ;
            try
            {

                ans = a / b;
            }

            catch (ArithmeticException e)
            {

                Console.WriteLine(e);
            }
        }

        public static void StackOverFlowMethod1(int value)
        {
            Console.WriteLine(value);
            StackOverFlowMethod1(++value);
        }
        public static void StackOverFlowMethod2()
        {
            try
            {
                //StackOverFlowMethod1(0);
            }
            catch (StackOverflowException e)
            {
                Console.WriteLine(e);
            }
        }


    }

}




