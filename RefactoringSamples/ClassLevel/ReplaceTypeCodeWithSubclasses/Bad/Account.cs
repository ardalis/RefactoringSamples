using System;
using System.Linq;

namespace InheritanceRefactorings.ReplaceTypeCodeWithSubclasses.Bad
{
    public class Account
    {
        public enum AccountType
        {
            Checking,
            Saving
        }

        public AccountType Type { get; private set; }

        public Account(AccountType type)
        {
            Type = type;
        }

        public decimal CalculateInterest(decimal amount)
        {
            if (this.Type == AccountType.Checking)
            {
                return amount;
            }
            return amount * 1.01m;
        }
    }
}
