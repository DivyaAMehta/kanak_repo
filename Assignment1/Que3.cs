using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{

    //3.	Write a C# program that demonstrates the use of Enums for countries
    //– INDIA, AUSTRALIA, USA, JAPAN, FRANCE, ENGLAND

    enum Countries
    {
        INDIA = 183,
        AUSTRALIA = 43,
        USA = 78,
        JAPAN = 1111,
        FRANCE = 18,
        ENGLAND = 33

    }

    class Que3
    {
        public static void Question3()
        {
            Console.WriteLine("{0} is the country and it has secret code {1}", Countries.INDIA, (int)Countries.INDIA);
        }



    }
}


//. An enum can be defined in a namespace, structure or class. However,
//it is better to define it in a namespace so that all the classes can access it.

//An enumeration, or Enum , is a symbolic name for a set of values. Enumerations are treated as data types,
//    and you can use them to create sets of constants for use with variables and properties.

