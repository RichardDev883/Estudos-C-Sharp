using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixacaoSeção10.Entities
{
    abstract class Collaborator
    {
        public string Name { get; set; }
        public double AnnualIncome { get; set; }

        public Collaborator()
        {

        }

        public Collaborator(string name, double annualIncome)
        {
            Name = name;
            AnnualIncome = annualIncome;
        }

        public abstract double Tax();
    }
}
