using System;

namespace Retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo r1 = new Retangulo();

            Console.WriteLine("Digite a largura e a altura do retângulo: ");
            r1.largura = float.Parse(Console.ReadLine());
            r1.altura = float.Parse(Console.ReadLine());

            Console.WriteLine("AREA: " + Math.Round(r1.area(), 2));
            Console.WriteLine("PERIMETRO: " + Math.Round(r1.perimetro(), 2));
            Console.WriteLine("DIAGONAL: " + Math.Round(r1.diagonal(), 2));
        }
    }
}
