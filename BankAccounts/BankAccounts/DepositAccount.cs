using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    class DepositAccount: Account
    {

        public DepositAccount(Customer customer, int balance, int interestRate, DateTime dateOfCreation)
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

        public int WithDraw(int value)
        {
            Balance = Balance - value;
            return Balance;
        }

        public override int CalculateIntetestAmount(int nrOfMonths)
        {
            if (Balance > 0 && Balance < 1000)
                return -1;
            else return InterestRate * nrOfMonths;
        }

    }
}
