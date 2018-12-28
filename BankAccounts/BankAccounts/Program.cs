using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Account> list = new List<Account>();
            var individual = new Individual("Monica");
            var individual2 = new Individual("Monica2");
            var company = new Company("Monica3");
            var company2 = new Company("Monica4");

            list.Add(new DepositAccount(individual, 100, 5, new DateTime(2018, 12, 20)));
            list.Add(new DepositAccount(individual, -50, 5, new DateTime(2010, 12, 20)));

            list.Add(new MortgageAccount(company, 30, 100, new DateTime(2018, 11, 20)));
            list.Add(new MortgageAccount(company, 30, 100, new DateTime(2010, 11, 20)));

            list.Add(new MortgageAccount(individual, 30, 100, new DateTime(2000, 11, 20)));
            list.Add(new MortgageAccount(individual2, 30, 100, new DateTime(2018, 11, 20)));

            list.Add(new LoanAccount(company, 55, 10, new DateTime(2018, 12, 20)));
            list.Add(new LoanAccount(individual2, 55, 10, new DateTime(2010, 12, 20)));

            var months = 6;
            foreach (var item in list)
            {
                Console.WriteLine("Account type: " + item.GetType());
                Console.WriteLine($"Interest rate per month is {item.InterestRate}");
                var x = item.CalculateIntetestAmount(months);
                if (x != -1)
                {
                    Console.WriteLine($"Interest rate for {months} months is {x}");
                }
                else
                {
                    Console.WriteLine("The customer has no interest available for this period because account was created on" +
                        $" {item.DateOfCreation.ToString("dd.MM.yyyy")};");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
            
        }
    }
}
