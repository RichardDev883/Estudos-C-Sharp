using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CursoCSharpN2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            List<Employed> list = new List<Employed>();

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter the ID: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Enter the Name: ");
                string name = Console.ReadLine();
                

                Console.Write("Enter the employee's Salary: ");
                double salary = double.Parse(Console.ReadLine());
                Console.WriteLine();

                list.Add(new Employed(id, name, salary));
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase : ");
            int searchId = int.Parse(Console.ReadLine());

            Employed emp = list.Find(x => x.Id == searchId);
            if( emp != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");

            foreach(Employed obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
    