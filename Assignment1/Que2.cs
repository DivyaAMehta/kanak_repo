using System;
using System.Text.RegularExpressions;

namespace Assignment1
{
    class Que2
    {
 

        public static void Question2()
        {
            bool symFlag = false;
            bool dotFlag = false;
            Console.WriteLine("Enter Email:");
            string email = Console.ReadLine();
            int emailLength = email.Length;

            for (int i = 0; i < emailLength - 1; i++)
            {
                if (email[i] == '@')
                    symFlag = true;
                if (email[i] == '.')
                    dotFlag = true;
                if (symFlag == true && dotFlag == true)
                {
                    Console.WriteLine("valid mail");
                    break;
                }
            }
            if (symFlag == false || dotFlag == false)
                Console.WriteLine("invalid mail");

            //Match match = Regex.Match(email);

        }
    }
}
