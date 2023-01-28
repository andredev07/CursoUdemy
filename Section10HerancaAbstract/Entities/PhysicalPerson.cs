using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section10HerancaAbstract.Entities
{
    class PhysicalPerson : Person
    {
        public double? HealthExpense { get; set; }

        public PhysicalPerson(double? healthExpense, string name, double annualIncome) : base(name, annualIncome)
        {
            HealthExpense = healthExpense;
        }

        public override double CalculateTax()
        {
            double percentageLow = 0.15;
            double percentageHigh = 0.25;
            double percentageHealthExpense = 0.5;

            if (AnnualIncome < 20000)
            {
                if (HealthExpense is not null)
                {
                    return (AnnualIncome * percentageLow) - ((double)HealthExpense * percentageHealthExpense);
                }

                return AnnualIncome * percentageLow;

            }

            if (HealthExpense is not null)
            {
                return (AnnualIncome * percentageHigh) - ((double)HealthExpense * percentageHealthExpense);
            }

            return AnnualIncome * percentageHigh;

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(Name + ", " + CalculateTax().ToString("C"));

            return sb.ToString();
        }
    }
}
