using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2OfDotNet
{
    public class Generic<T>
    {
        private T data;

        // using properties
        public T value
        {
            // using accessors
            get
            {
                return this.data;
            }
            set
            {
                this.data = value;
            }
        }
    }

     class Questions6
    {


       public static void GenericClassExplain()
        {           
            Generic<string> name = new Generic<string>();// object of string type
            name.value = "kanak";

            Generic<float> version = new Generic<float>();
            version.value = 1.8F;
            Console.WriteLine("generic Class AndMethods------------------------------------------------------");
            Console.WriteLine(name.value);

            Console.WriteLine(version.value);
        }
    }
}
