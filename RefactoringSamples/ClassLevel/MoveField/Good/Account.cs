using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRefactorings.MoveField.Bood
{
    public class AccountType
    {
        public decimal InterestRate { get; private set; }
    }

    public class Account
    {
        private AccountType _type;

        // other methods that use InterestRate

        public decimal CalculateInterest(decimal amount, int days)
        {
            return amount * _type.InterestRate * days / 365;
        }
    }
}
