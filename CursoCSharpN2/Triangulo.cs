using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpN2
{
     class Triangulo
    {
        //Lados do Triangulo
        public double A;
        public double B;
        public double C;

        // Método para Calcular a Area
        public double Area()
        {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        /*Exercicio Feito


        ------ Instanciando o Triangulo ------
         Triangulo x,y;

            x = new Triangulo();
            y = new Triangulo();

        ------ Pegando os dados ------
            Console.WriteLine("Digite as medidas do triangulo x: ");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite as medidas do triangulo y: ");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

        ------ Retornando o Método ------
            double areaX = x.Area();
            double areaY = y.Area();

            Console.WriteLine("Area do triangulo X é igual a: " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area do triangulo Y é igual a: " + areaY.ToString("F4", CultureInfo.Invar
        */
    }
}
