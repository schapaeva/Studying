using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeExample
{
    public class Employee
    {
        public string _firstName { get; set; }
        private double _salary { get; set; }
        public List<Employee> _subordinates { get; set; }

        public Employee(string firstName, double salary)
        {
            _firstName = firstName;
            _salary = salary;
            _subordinates = new List<Employee>();
        }

        public void AddSubordinate(Employee subordinate)
        {
            _subordinates.Add(subordinate);
        }

         


        
    }
}
