using System;
using System.Collections.Generic;
using System.Linq;

namespace RefactoringSamples.ClassLevel.ReplaceInheritanceWithDelegation.Good
{
    public class Company
    {
        private List<Employee> _employees = new List<Employee>();

        public int Count { get { return _employees.Count; } }

        public IEnumerable<Employee> ListCurrentEmployees()
        {
            return _employees.Where(e => e.IsEmployed).AsEnumerable();
        }
        public void Hire(Employee employee)
        {
            _employees.Add(employee);
        }
        public void Fire(Employee employee)
        {
            _employees.Remove(employee);
        }
    }

    public class ClientCode
    {
        public void Main()
        {
            var company = new Company();

            var employees = company.ListCurrentEmployees();

            var employee = new Employee();

            // ok
            company.Hire(employee);

            // ok
            company.Fire(employee);

            // should not be allowed
            // company.Clear();

            int count = company.Count;
        }
    }

}
