using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeExample
{
    class Program
    {
        static void Main(string[] args)
        { 
            Employee bryan = new Employee("Bryan", 100000);
            Employee evan = new Employee("Evan", 90000);
            Employee marta= new Employee("Marta", 95000);
            Employee robyn = new Employee("Robyn", 95000);
            Employee sandra = new Employee("Sandra", 80000);

            bryan.AddSubordinate(evan);
            bryan.AddSubordinate(marta);
            evan.AddSubordinate(robyn);


        }
    }
}
