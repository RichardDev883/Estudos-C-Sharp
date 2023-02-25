using ExercicioFinalSecao10.Entities;
using System.Globalization;

namespace ExercicioFinalSecao10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth Date (MM/DD/YYYY): ");
            DateTime birthday = DateTime.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Client cliente = new Client(name, email, birthday);

            Console.WriteLine("Teste");
        }
    }
}