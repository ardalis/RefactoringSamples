using System.Collections.Generic;
using System.Linq;

namespace RefactoringSamples.ClassLevel.ReplaceInheritanceWithDelegation.Bad
{
    public class Company : List<Employee>
    {
        public IEnumerable<Employee> ListCurrentEmployees()
        {
            return this.Where(e => e.IsEmployed).AsEnumerable();
        }
        public void Hire(Employee employee)
        {
            this.Add(employee);
        }
        public void Fire(Employee employee)
        {
            this.Remove(employee);
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
            company.Clear();
        }
    }

}
