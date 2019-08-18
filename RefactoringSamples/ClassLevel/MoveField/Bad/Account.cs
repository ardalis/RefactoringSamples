using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRefactorings.MoveField.Bad
{
    public class AccountType
    {
    }

    /// <summary>
    /// Translated into C# from Fowler's Refactoring book
    /// </summary>
public class Account
{
    private AccountType _type;
    private decimal _interestRate;

    // other methods that use _interestRate

    public decimal CalculateInterest(decimal amount, int days)
    {
        return amount * _interestRate * days / 365;
    }
}
}
