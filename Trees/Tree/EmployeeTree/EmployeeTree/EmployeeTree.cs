using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTreeExample
{
    public class Employee
    {
        private string name;
        private double salary;
        private List<Employee> subordinates;

        public Employee(string name)
        {
            this.name = name;
            this.salary = 0.0;
            this.subordinates = null;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public List<Employee> Subordinates
        {
            get { return this.subordinates; }
            set { this.subordinates = value; }
        }

        public void AddSubordinate(Employee employee)
        {
            if (this.subordinates == null)
                this.subordinates = new List<Employee>();
            this.subordinates.Add(employee);
        }

        public List<Employee> GetPath(string name)
        {
            var path = new Stack<Employee>();
            path.Push(this);

            var found = LookupPath(path, name);

            if (found)
            {
                return path.Reverse().ToList();
            }
            else
            {
                throw new Exception("Could not find employee with name " + name);
            }
        }

        private bool LookupPath(Stack<Employee> currentPath, string lookupName)
        {
            if (currentPath.Peek().Name == lookupName)
            {
                return true;
            }

            if (currentPath.Peek().Subordinates == null)
            {
                return false;
            }

            foreach (var child in currentPath.Peek().Subordinates)
            {
                currentPath.Push(child);

                if (LookupPath(currentPath, lookupName))
                {
                    return true;
                }

                currentPath.Pop();
            }
            return false;
        }
    } 

}
