namespace RefactoringSamples.ClassLevel.TemporaryField
{
    public class BonusCalculator
    {
        private Employee _employee;

        public BonusCalculator(Employee employee)
        {
            _employee = employee;
        }
        public decimal CalculateBonus()
        {
            return CalculateEarningsForBonus() * _employee.BonusPercentage();
        }
        private decimal CalculateEarningsForBonus()
        {
            return _employee.YearToDateEarnings() + _employee.OvertimeEarnings() * 2;
        }
    }
}
