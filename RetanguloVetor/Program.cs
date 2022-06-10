using System;

namespace RetanguloVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantidade de retângulos: "); int qtdeRetangulos = int.Parse(Console.ReadLine());
            Retangulo[] r = new Retangulo[qtdeRetangulos];
            //define limite do for e do vetor
            
            for (int i = 0; i < qtdeRetangulos; i++)
            {
                Console.WriteLine("Digite a largura e a altura do retângulo: ");
                double altura = double.Parse(Console.ReadLine());
                double largura = double.Parse(Console.ReadLine());

                r[i] = new Retangulo(altura, largura);

                Console.WriteLine("AREA: " + r[i].Area());
                Console.WriteLine("PERIMETRO: " + r[i].Perimetro());
                Console.WriteLine("DIAGONAL: " + r[i].Diagonal());
            }
        }
    }
}
