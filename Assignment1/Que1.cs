using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
   public class Add
    {
     public static void  Question1()
        {
            AddValues O1 = new AddValues();
            O1.Display();
            StringOperation O2 = new StringOperation();
            O2.DisplayCharecterStringComparison();
            StringOperation O3 = new StringOperation();
            O3.DisplayConcatCharString();
            StringOperation O4 = new StringOperation();
            O4.DisplaySubstring();
            StringOperation O5 = new StringOperation();
            O5.DisplayTogetherOfString();

        }
    }
    class AddValues
    {
        static int x = 5;
        static int y = 6;
        int sum = x + y;
        public void Display()
        {
            Console.WriteLine(sum); // Print the sum of x + y}

        }
    }


    class StringOperation
    {
        char[] carray1 = { 'a', 'b', 'c', 'd' };
        char[] carray2 = { 'a', 'b', 'c', 'd', 'e' };
        string[] sarray1 = { "hii", "how", "are", "you" };


        public void DisplayCharecterStringComparison()
        {
            if (carray1 == carray2)
                Console.WriteLine("string is equal");
            else
                Console.WriteLine("not equal");

        }

        public void DisplayConcatCharString()
        {
            Console.WriteLine("concat:");
            Console.WriteLine(carray1[0] + carray2[0]);  
        }

        public void DisplaySubstring()
        {
            string substring = sarray1[0].Substring(0, 2);
            Console.WriteLine("substring: ");
            Console.WriteLine(substring);
        }

        public void DisplayReverseCharecterArray()
        {
            int len1 = carray1.Length;
            Console.WriteLine("Reverse:");
            for (int i = len1 - 1; i >= 0; i--)
                Console.WriteLine(carray1[i]);
        }

        //b.Built-in functions for ‘string’ variables

        string variable1 = "kanak";
        string variable2 = "kini";

        public void DisplayTogetherOfString()
        {
            Console.WriteLine("is same?:");
            bool ans = string.Equals(variable1, variable2);
            if (ans)
                Console.WriteLine("equal");
            else
                Console.WriteLine("not equal");

            string concatString = String.Concat(variable1, variable2);
            Console.WriteLine("concat:");
            Console.WriteLine(concatString);

            Console.WriteLine("substring:");
            string substring = variable1.Substring(0, 3);
            Console.WriteLine(substring);

            Console.WriteLine("reverse:");
            //string resultstring = variable2.Reverse().ToArray();
            Console.WriteLine(variable2);

        }

    }

}

