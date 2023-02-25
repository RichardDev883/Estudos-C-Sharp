using PracticeEnum.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Globalization;
using PracticeEnum.Entities;

namespace PracticeEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Analyst department capture

            Console.WriteLine("Enter department's Name: ");
            string deptName = Console.ReadLine();


            //Analyst Data
            Console.WriteLine("Enter Worker Data");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Instantiating Department and Worker 
            Department dept = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            //Definition of the amount of contracts
            Console.WriteLine("How many contracts to this worker?");
            int n = int.Parse(Console.ReadLine());

            for(int i =1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} to this worker");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Value Per Hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.addContract(contract);
            }


            Console.WriteLine("");
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));
            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Department.Name);
            Console.WriteLine("Income for " + monthAndYear + ": " + worker.Income(year, month));
        }
    }
}