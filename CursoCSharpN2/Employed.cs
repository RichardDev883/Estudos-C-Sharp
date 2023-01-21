using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpN2
{
    internal class Employed
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public  double Salary { get; set; }
        
        public void IncreaseSalary(double percentage)
        {
            Salary += Salary * (percentage / 100);
        }

    }
}
