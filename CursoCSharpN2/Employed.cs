using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CursoCSharpN2
{
    internal class Employed
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public  double Salary { get; private set; }
        

        public Employed(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }
        public void IncreaseSalary(double percentage)
        {
            Salary += Salary * (percentage / 100);
        }

        public override string ToString()
        {
            return Id
                + ", "
                + Name
                + ", "
                + "R$ " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
