using HerancaPolimorfismo.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Product> list = new List<Product>();

        Console.Write("Enter the number of products: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"Product #{i} data: ");
            Console.Write("Common, used, imported (c/u/i): ");
            char answer = char.Parse(Console.ReadLine());
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Price: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (answer == 'c')
            {
                list.Add(new Product(name, price));
            }
            else if (answer == 'u')
            {
                Console.Write("Manufacture Date (MM/DD/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new UsedProduct(name, price, date));
            }
            else
            {
                Console.Write("Customs Fee: ");
                double customsFee = double.Parse(Console.ReadLine());
                list.Add(new ImportedProduct(name, price, customsFee));
            }
        }
        Console.WriteLine();
        Console.WriteLine("Price Tags: ");
        foreach (Product product in list)
        {
            Console.WriteLine(product.PriceTag());
        }
    }
}