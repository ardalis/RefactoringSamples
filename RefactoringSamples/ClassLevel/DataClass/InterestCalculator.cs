using System;

namespace RefactoringSamples.ClassLevel.DataClass
{
    public class InterestCalculator
    {
        private decimal _interestRate = 1.01m;

        public void CalculateInterest(Account account)
        {
            if (account.AccountType == "Checking")
            {
                return;
            }
            if (account.AccountType == "Savings")
            {
                decimal interest = account.Balance * this._interestRate;
                account.Balance += interest;
                return;
            }
            throw new InvalidOperationException(string.Format("Unknown Account Type: {0}", account.AccountType));
        }
    }

}
