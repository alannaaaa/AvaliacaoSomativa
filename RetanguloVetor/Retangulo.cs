using System;
namespace RetanguloVetor
{
    class Retangulo
    {
        public double Altura { get; set; }
        public double Largura { get; set; }

        //construtor
        public Retangulo(double altura, double largura)
        {
            Altura = altura;
            Largura = largura;
        }

        //metodos que calculam a are, perimetro e diagonal
        public double Area()
        {
            return Math.Round(Altura * Largura, 2);
        }

        public double Perimetro()
        {
            return Math.Round(2 * (Altura + Largura), 2);
        }

        public double Diagonal()
        {
            return Math.Round(Math.Sqrt((Largura * Largura) + (Altura * Altura)), 2);
        }
    }
}
