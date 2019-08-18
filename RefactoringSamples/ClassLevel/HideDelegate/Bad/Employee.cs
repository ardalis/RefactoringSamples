using System;
using System.Linq;

namespace ClassRefactorings.HideDelegate.Bad
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
    }

    public class Client
    {
        public void DoSomething(Employee employee)
        {
            var manager = employee.Department.Manager;
        }
    }
}
