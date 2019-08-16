using System;

namespace RefactoringSamples.ClassLevel.DataClass
{
    public class RefactoredInterestCalculator
    {
        private decimal _interestRate = 1.01m;

        public decimal CalculateInterest(RefactoredAccount account)
        {
            if (account.AccountType == "Checking")
            {
                return 0;
            }
            if (account.AccountType == "Savings")
            {
                decimal interest = account.Balance * this._interestRate;
                return interest;
            }
            throw new InvalidOperationException(string.Format("Unknown Account Type: {0}", account.AccountType));
        }
    }

}
