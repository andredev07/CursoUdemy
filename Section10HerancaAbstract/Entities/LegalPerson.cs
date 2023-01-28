using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section10HerancaAbstract.Entities
{
    class LegalPerson : Person
    {
        public int NumberOfEmployees { get; set; }

        public LegalPerson(int numerOfEmployees, string name, double annualIncome) : base(name, annualIncome)
        {
            NumberOfEmployees = numerOfEmployees;
        }

        public override double CalculateTax()
        {
            double percentageLow = 0.14;
            double percentageHigh = 0.16;

            if (NumberOfEmployees > 10)
            {
                return AnnualIncome * percentageLow;
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
