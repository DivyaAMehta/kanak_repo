using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment2OfDotNet
{
    class EmployeeSalary
    {
        string emp_name;
        int emp_sal;
        public string ToString()
        {
            return (emp_name+ " " + emp_sal);
        }

        public static void EmployeeSalaryMethod()
        {
            List<EmployeeSalary> Emp = new List<EmployeeSalary>()
            {
                 new EmployeeSalary{ emp_name="name1",emp_sal=8000 },
                 new EmployeeSalary { emp_name = "name2", emp_sal = 7000 },
                 new EmployeeSalary { emp_name = "name3", emp_sal = 9000 },
            };
            IEnumerable<EmployeeSalary> Query = from data in Emp
                                                orderby data.emp_sal ascending
                                                select data;

            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("Name AscendingSalary");
            foreach (EmployeeSalary all in Query)                      //foreach loop for select list item
            {
                Console.WriteLine(all.ToString());
            }
        }
       
}
}
