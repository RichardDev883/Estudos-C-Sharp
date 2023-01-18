using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CursoCSharpN2
{
     class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;


        public Produto( string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public override string ToString()
        {
            return Nome + ", $"
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                +" Unidades, Total: "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

        public void AdicionarProduto(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProduto(int quantidade)
        {
            Quantidade -= quantidade;   
        }

        /*
            Console.WriteLine("Entre com os dados do produto");
            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto b;
            b = new Produto(nome, preco, quantidade);

            Console.WriteLine("Dados do Produto: " + b);

            Console.WriteLine();
            Console.WriteLine("Adicionar Estoque: ");
            int qte = int.Parse(Console.ReadLine());
            b.AdicionarProduto(qte);
            Console.WriteLine("Dados do Produto: " + b);

            Console.WriteLine();
            Console.WriteLine("Remova Estoque: ");
            qte = int.Parse(Console.ReadLine());
            b.RemoverProduto(qte);
            Console.WriteLine("Dados do Produto: " + b);
        */
    }
}
