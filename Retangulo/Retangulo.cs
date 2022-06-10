namespace Retangulo
{
    class Retangulo
    {
        public float largura, altura;

        public float area()
        {
            return largura * altura;
        }
        public float perimetro()
        {
            return 2 * (largura + altura);
        }
        public float diagonal()
        {
            return (float)Math.Sqrt((largura * largura) + (altura * altura));
        }
    }
}
