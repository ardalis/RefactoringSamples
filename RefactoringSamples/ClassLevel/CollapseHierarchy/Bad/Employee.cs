using System;
using System.Collections.Generic;
using System.Linq;

namespace InheritanceRefactorings.CollapseHierarchy.Bad
{
    public class Employee
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public Employee Manager { get; set; }
    }

    public class Manager : Employee
    {
        public IReadOnlyList<Employee> DirectReports { get; set; }

        public decimal CalculateBonus()
        {
            return 0.10m * Salary;
        }
    }
}
