using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculationApp
{
    internal class Account
    {
        public string AccountNumebr { set; get; }
        public string OpeningDate { set; get; }
        public double Blance { private set; get; }

        public double Deposite(double amount)
        {
            Blance += amount;
            return  Blance;
        }
        public double Withdraw(double amount)
        {
            Blance -= amount;
            return  Blance;
        }
    }
}
