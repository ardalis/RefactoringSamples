namespace RefactoringSamples.ClassLevel.DataClass
{
    public class RefactoredAccount
    {
        public RefactoredAccount(int id, string accountType, decimal balance)
        {
            Id = id;
            AccountType = accountType;
            Balance = balance;
        }

        public int Id { get; }
        public string AccountType { get; }
        public decimal Balance { get; private set; }

        public void CalculateAndApplyInterest(RefactoredInterestCalculator calculator)
        {
            var interest = calculator.CalculateInterest(this);

            IncreaseBalance(interest);
        }

        private void IncreaseBalance(decimal amount)
        {
            // add logging and audit trail
            Balance += amount;
        }
    }
}
