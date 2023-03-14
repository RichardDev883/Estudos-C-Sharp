using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixacaoSeção10.Entities
{
    internal class LegalPerson : Collaborator
    {
        public double NumberOfEmployees { get; set; }

        public LegalPerson()
        {

        }

        public LegalPerson(string name, double annualIncome, double numberOfEmployees) : base (name, annualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            if (NumberOfEmployees > 10)
            {
                return AnnualIncome * 0.14;
            }
            else
            {
                return AnnualIncome * 0.16;
            }
        }
    }
}
