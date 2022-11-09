using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2OfDotNet
{
    class Question4
    {
        public static void ReadFile()
        {
            System.Console.WriteLine("READ TEXT FILE................................................................");
            string text = System.IO.File.ReadAllText(@"C:\Users\Kanak.Kini\source\repos\Question4\readthisfile.txt");
            System.Console.WriteLine("Contents of WriteText.txt = {0}", text);

        }
    }
}
