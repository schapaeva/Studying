using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTreeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee frank = new Employee("Frank");
            Employee tom = new Employee("Tom");
            Employee rob = new Employee("Rob");
            Employee bryan = new Employee("Bryan");
            Employee sarah = new Employee("Sarah");
            Employee sandra = new Employee("Sandra");
            Employee marta = new Employee("Marta");
            Employee evan = new Employee("Evan");
            Employee chris = new Employee("Chris");

            frank.AddSubordinate(tom);
            frank.AddSubordinate(rob);
            frank.AddSubordinate(bryan);
            tom.AddSubordinate(sarah);
            tom.AddSubordinate(sandra);
            bryan.AddSubordinate(marta);
            bryan.AddSubordinate(evan);
            evan.AddSubordinate(chris);

            PrintPathList(bryan.GetPath(chris.Name));

            Console.ReadKey();
        }

        public static void PrintPathList(List<Employee> pathList)
        {
            for (int i = 0; i < pathList.Count; i++)
            {
                Console.Write(pathList[i].Name);
                if (i != pathList.Count - 1)
                    Console.Write("->");
            }
            Console.Write("\n");
        }
    }
}
