using System;

namespace Salarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();

            Console.Write("Nome: ");
            p1.nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            p1.salarioBruto = float.Parse(Console.ReadLine());
            Console.WriteLine(">>> IMPOSTO R$100 <<<");
            Console.WriteLine();
            Console.WriteLine("    >> SALARIO BRUTO DE " + p1.nome.ToUpper() + ": " + p1.salarioBruto.ToString("C"));
            Console.WriteLine("    >> SALARIO LIQUIDO DE " + p1.nome.ToUpper() + ": " + p1.salarioLiquido().ToString("C"));
            Console.WriteLine();
            Console.WriteLine("Deseja aumentar seu salário em quantos %?");
            p1.aumento = float.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("    >> SALÁRIO BRUTO DE " + p1.nome.ToUpper() + " (com aumento): " + p1.salarioBrutoAumentado().ToString("C"));
            Console.WriteLine("    >> SALÁRIO LIQUIDO DE " + p1.nome.ToUpper() + " (com aumento): " + (p1.salarioBrutoAumentado() - p1.imposto).ToString("C"));

        }
    }
}
