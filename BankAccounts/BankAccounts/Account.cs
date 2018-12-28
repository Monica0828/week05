using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    abstract class Account
    {
        public Customer Customer { get; set; }

        public int Balance { get; set; }

        public virtual bool IsInterestRateAllowed { get; }

        public int InterestRate { get; set; }

        public DateTime DateOfCreation { get; set; }

        public abstract int Deposit(int value);

        public virtual int CalculateIntetestAmount(int nrOfMonths)
        {
            return InterestRate * nrOfMonths;
        }
    }
}
