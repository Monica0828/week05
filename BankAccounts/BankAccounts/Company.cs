﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    class Company : Customer
    {
        public Company(string name)
        {
            Name = name;
            Type = CustomerType.Company;
        }
    }
}
