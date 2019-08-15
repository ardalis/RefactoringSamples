using System;
using System.Collections.Generic;
using System.Text;

namespace RefactoringSamples.ClassLevel.TemporaryField
{
    public class Employee
    {
        private decimal _earningsForBonus;

        // other fields and methods  
        private decimal CalculateBonus()
        {
            return _earningsForBonus * BonusPercentage();
        }

        public decimal BonusPercentage()
        {
            throw new NotImplementedException();
        }

        private void CalculateEarningsForBonus()
        {
            _earningsForBonus = YearToDateEarnings() + OvertimeEarnings() * 2;
        }

        public int YearToDateEarnings()
        {
            throw new NotImplementedException();
        }

        public int OvertimeEarnings()
        {
            throw new NotImplementedException();
        }
    }
}
