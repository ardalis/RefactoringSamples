using System;
using System.Collections.Generic;
using System.Linq;

namespace InheritanceRefactorings.CollapseHierarchy.Good
{
    public class Employee
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public Employee Manager { get; set; }
        public IReadOnlyList<Employee> DirectReports { get; set; }
    }

    public class BonusCalculator
    {
        public decimal CalculateBonusFor(Employee employee)
        {
            return 0;
        }
    }
}