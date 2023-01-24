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
            Console.Write("Enter the numbers of employees: ");
            int n = int.Parse(Console.ReadLine());

            List<Employed> list = new List<Employed>();

            for(int i = 0; i < n; i++)
            {
                Console.Write("Enter the ID: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Enter name of employee: ");
                string name = Console.ReadLine();

                Console.Write("Enter the Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();

                //Add das info a List
                list.Add(new Employed(id, name, salary));
            }

            Console.Write("Enter the id of employee it will receveid incresead salary: ");
            int searchID = int.Parse(Console.ReadLine());

            Employed emp = list.Find(x => x.Id == searchID); //Expressão LAMBDA para conferir List com ID digitado
            
            if(emp != null) //validação null
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percentage); //metodo do aumento
            }
            else
            {
                Console.WriteLine("This id does not exist!");
                Environment.Exit(0);
            }
            Console.WriteLine();

            Console.WriteLine("Updated list of employees:");

            //Abaixo um foreach para percorrer a list criada e apresentar os dados atualizados
            foreach (Employed obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
    