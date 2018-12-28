using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    interface IAccount
    {
        ICustomer Customer { get; set; }

        int Balance { get; set; }

        int InterestRate { get; set; }

        int Deposit(int value);
    }
}
