using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpN2
{
    class Aluno
    {
        public string Nome;
        public double Nota1, Nota2, Nota3;


        public double SomaNota()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public bool Aprovado()
        {
            if(SomaNota() >= 60.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double NotaRestante()
        {
            if (Aprovado())
            {
                return 0.0;
            }
            else
            {
                return 60 - SomaNota();
            }
        }

        /*
         *  Aluno aluno = new Aluno();

            Console.Write("Digite o Nome do Aluno: ");
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("Digite as 3 notas do Aluno: ");
            aluno.Nota1 = double.Parse(Console.ReadLine());
            aluno.Nota2 = double.Parse(Console.ReadLine());
            aluno.Nota3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Nota Final: " + aluno.SomaNota());

            if (aluno.Aprovado())
            {
                Console.WriteLine("APROVADO");
            }

            else
            {
                Console.WriteLine("ALUNO REPROVADO");
                Console.WriteLine("FALTARAM " + aluno.NotaRestante() + " PONTOS");
            }
        */
    }
}
