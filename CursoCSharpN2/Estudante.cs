using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpN2
{
    internal class Estudante
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public Estudante(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public override string ToString()
        {
            return Nome + ", " + Email;
        }
    }

    /*
     *  Estudante[] vect = new Estudante[10];

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
    */
}
