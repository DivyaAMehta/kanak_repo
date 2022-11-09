using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2OfDotNet
{
  
class Student
    {

        int sId;
        string sDept;
        string sName;
        int sSem;

        public  string ToString()
        {
            return (sId + " " + sName + " " +sDept + "           " + sSem);
        }

        public static void LinqMethod()
        {

            List<Student> stu = new List<Student>()
    {
          
        // Create 3 Student 
        new Student{ sId = 101, sName = "name1",
                     sDept = "CSE", sSem = 2 },
        new Student{ sId = 102, sName = "name2",
                     sDept = "CSE", sSem = 1 },
        new Student{ sId = 103, sName = "name3",
                     sDept = "CSE", sSem = 4},
    };

            //list query syntax for linq querry
            IEnumerable<Student> Query = from student in stu select student;

            Console.WriteLine("ID  Name  Department Semester");
            foreach (Student all in Query)                      //foreach loop for select list item
            {
                Console.WriteLine(all.ToString());
            }
        }
    }
}

