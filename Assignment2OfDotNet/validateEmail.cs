using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Net.Mail;

namespace Assignment2OfDotNet
{

    public class ProgramEmail
    {
        
        public static void ValidateMail()
        {
                Console.WriteLine("QN 1---------------------------------------------------------------------------------------------------");
                Regex validateEmailRegex = new Regex("^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$");
            string email = "kanakkini18@mail.com@@";
            Console.WriteLine($"The email : {email}");
            bool ans=validateEmailRegex.IsMatch(email);
            if (!ans)
            {
                Console.WriteLine($"is invalid");
            }
            else
            {
                Console.WriteLine($"The email is valid");
            }
                

        }
    }
    
}
