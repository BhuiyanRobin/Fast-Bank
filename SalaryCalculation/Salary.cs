using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculation
{
    class Salary
    {
        public double Basic { set; get; }
        public double Convenyence { set; get; }
        public double Medical { set; get; }

        public double Increment(double amount)
        {
            return Basic += Basic*amount/100;
        }

        public double TotalSalary()
        {
            double totalSalary = Basic + ConveneyenceAmount()+MedicalAmount();
            return totalSalary;
        }

        public double ConveneyenceAmount()
        {
            
            return (Basic*Convenyence/100) ;
        }
        public double MedicalAmount()
        {
            return (Basic * Medical / 100);
        }
    }
}
