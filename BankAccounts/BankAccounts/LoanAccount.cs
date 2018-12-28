using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    class LoanAccount : Account
    {

        public LoanAccount(Customer customer, int balance, int interestRate, DateTime dateOfCreation)
        {
            Customer = customer;
            Balance = balance;
            InterestRate = interestRate;
            DateOfCreation = dateOfCreation;
        }

        public override int Deposit(int value)
        {
            Balance = Balance + value;
            return Balance;
        }

        public override int CalculateIntetestAmount(int nrOfMonths)
        {
            if (IsInterestRateAllowed)
                return nrOfMonths * InterestRate;
            else
                return -1;
        }

        public override bool IsInterestRateAllowed =>
            (DateTime.Today.AddMonths(-3) >= DateOfCreation && Customer.Type == CustomerType.Individual)
            || (DateTime.Today.AddMonths(-2) >= DateOfCreation && Customer.Type == CustomerType.Company);
    }
}
