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
            Estudante[] vect = new Estudante[10];

            Console.WriteLine("Quantos quartos vao ser alugados?");    
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for ( int i = 0; i < n; i++)
            {
                Console.WriteLine("Alugel #" + (i+1) + ": ");
                Console.Write("Nome do Estudante: ");
                string nome =  Console.ReadLine();
                Console.Write("Digite o email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                Console.WriteLine();

                vect[quarto] = new Estudante(nome, email);
            }

            Console.WriteLine("----------------");
            Console.WriteLine("Quartos Alugados: ");
            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }
        }
    }
}
    