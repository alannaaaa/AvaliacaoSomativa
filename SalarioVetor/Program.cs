using System;

namespace SalarioVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            //define o limite do for e do vetor
            Console.WriteLine("Quantidade de funcionários: "); int qtdeFuncionarios = int.Parse(Console.ReadLine());
            Funcionario[] f = new Funcionario[qtdeFuncionarios]; //vetor de funcionarios

            for (int i = 0; i < qtdeFuncionarios; i++) //for que vai até o limite de funcionarios digitados
            {
                Console.Write("> Nome: "); string nome = Console.ReadLine();
                Console.Write("> Salário Bruto: "); double salB = double.Parse(Console.ReadLine());
                Console.Write("> Valor em porcentagem dos impostos: "); int imposto = int.Parse(Console.ReadLine());

                f[i] = new Funcionario(nome, salB, imposto);
                Console.WriteLine(); Console.WriteLine(f[i]); Console.WriteLine(); Console.ResetColor();

                Console.Write(">> Valor percentual do aumento: "); int aumento = int.Parse(Console.ReadLine()); f[i].AumentaSal(aumento);

                Console.WriteLine(); Console.WriteLine(f[i]); Console.ResetColor();
            }
        }
    }
}