using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    class MortgageAccount : Account
    {

        public MortgageAccount(Customer customer, int balance, int interestRate, DateTime dateOfCreation)
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

            if (Customer.Type == CustomerType.Company)
                if (DateOfCreation >= DateTime.Today.AddMonths(-12))
                    return (nrOfMonths * InterestRate) / 2;
                else return nrOfMonths * InterestRate;
            else

            if (Customer.Type == CustomerType.Individual)
                if (IsInterestRateAllowed)
                    return nrOfMonths * InterestRate;
                else
                    return -1;
            else return -1;
        }

        public override bool IsInterestRateAllowed =>
             (DateTime.Today.AddMonths(-2) >= DateOfCreation && Customer.Type == CustomerType.Individual);
    }
}
