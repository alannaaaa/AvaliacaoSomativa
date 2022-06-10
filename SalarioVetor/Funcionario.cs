namespace SalarioVetor
{
    class Funcionario
    {
        public string Nome { get; set; }
        public double SalB { get; set; }
        public int Imposto { get; set; }

        //construtor
        public Funcionario(string nome, double salB, int imposto)
        {
            Nome = nome;
            SalB = salB;
            Imposto = imposto;
        }

        //cacula salario liquido
        public double SalLiquido()
        {
            return SalB - (Imposto / 100.0 * SalB);
        }

        //calcula o aumento do salario em cima do salario bruto (aumentado ou nao)
        public void AumentaSal(double aumento)
        {
            SalB += aumento / 100.0 * SalB;
        }

        //imprime os dados usando os metodos.
        public override string ToString()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            return "                 RELATÓRIO DE "
                + Nome.ToUpper()
                + "\n\n"
                + "\nSALÁRIO BRUTO: "
                + SalB.ToString("F2")
                + "\nSALÁRIO LÍQUIDO: "
                + SalLiquido().ToString("F2")
                + "\nIMPOSTO("
                + Imposto + "%)"
                + "\n\n"
                + "-------------------------------------------------------";
        }
    }
}
