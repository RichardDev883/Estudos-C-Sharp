using ExercicioFixacaoSeção10.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Collaborator> collaborators= new List<Collaborator>();
        Console.Write("Enter the number of taxpayers: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"Tax payer #{i} data: ");
            Console.Write("Individual or company (i/c) ? ");
            char type = char.Parse(Console.ReadLine());
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Anual income: ");
            double annualIncome = double.Parse(Console.ReadLine());

            if (type == 'i')
            {
                Console.Write("Health Expedintures: ");
                double healthSpending = double.Parse(Console.ReadLine());
                collaborators.Add(new PhysicalPerson(name, annualIncome, healthSpending));
            }
            else
            {
                Console.Write("Number of employees: ");
                int numberOfEmployees = int.Parse(Console.ReadLine());
                collaborators.Add(new LegalPerson(name, annualIncome, numberOfEmployees));
            }
        }
            double sum = 0.0;
            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");

            foreach(Collaborator c in collaborators)
            {
                double tax = c.Tax();
                Console.WriteLine(c.Name + ": $ " + tax.ToString("F2", CultureInfo.InvariantCulture));
                sum += tax;
            }
            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));
        
    }
}