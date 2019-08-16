using System;
using System.Collections.Generic;
using System.Linq;

namespace InheritanceRefactorings.ReplaceDelegationWithInheritance.Good
{
    public class EmployeeCollection : List<Employee>
    {
        public IEnumerable<Employee> ListCurrentEmployees()
        {
            return this.Where(e => e.IsEmployed).AsEnumerable();
        }
    }
}
