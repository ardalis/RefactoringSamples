using System;
using System.Linq;

namespace ClassRefactorings.HideDelegate.Good
{
    public class Department
    {
        public string Name { get; set; }
        public Employee Manager { get; set; }
    }

    public class Employee
    {
        public string Name { get; set; }
        public Department Department { get; set; }
        public Employee Manager
        {
            get
            {
                return this.Department.Manager;
            }
        }
    }

    public class Client
    {
        public void DoSomething(Employee employee)
        {
            var manager = employee.Manager;
        }
    }
}
