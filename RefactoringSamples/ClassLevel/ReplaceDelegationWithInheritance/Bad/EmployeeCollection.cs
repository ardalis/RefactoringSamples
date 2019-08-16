using System;
using System.Collections.Generic;
using System.Linq;

namespace InheritanceRefactorings.ReplaceDelegationWithInheritance.Bad
{
    public class EmployeeCollection
    {
        private List<Employee> _employees = new List<Employee>();

        public int Count { get { return _employees.Count; } }

        public IEnumerable<Employee> ListCurrentEmployees()
        {
            return _employees.Where(e => e.IsEmployed).AsEnumerable();
        }
        public void Add(Employee employee)
        {
            _employees.Add(employee);
        }
        public void Remove(Employee employee)
        {
            _employees.Remove(employee);
        }
    }
}
