using System;

namespace AlunoNotasVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            //perguntas para definir limites de for e vetor
            Console.Write("Quantidade de alunos: "); int qtdeAlunos = int.Parse(Console.ReadLine());
            Console.Write("Quantidade de notas por aluno: "); int qtdeNotas = int.Parse(Console.ReadLine());

            //vetores para guardar alunos, suas notas e a soma das notas.
            Alunos[] a = new Alunos[qtdeAlunos];
            Notas[] n = new Notas[qtdeNotas];
            double[] somaNotas = new double [qtdeNotas];

            //for que pergunta continuamente os nomes
            for (int i = 0; i < qtdeAlunos; i++)
            {
                Console.WriteLine("Nome do aluno: "); string nome = Console.ReadLine();
                a[i] = new Alunos(nome);

                //for que pergunta as notas por alunos
                for (int j = 0; j < qtdeNotas; j++)
                {
                    Console.Write("Nota " + (j+1) + ": "); double nota = double.Parse(Console.ReadLine());
                    n[j] = new Notas(nota);

                    //verifica se cada nota for maior que o limite 30 para digitar novamente
                    while (nota > 30)
                    {
                        if (nota > 30)
                        {
                            Console.WriteLine("Nota inválida, digite novamente! (nota máxima: 30) ");
                            Console.Write("Nota " + (j + 1) + ": "); nota = double.Parse(Console.ReadLine());
                        }
                    }

                    //soma as notas e guarda num vetor.
                    somaNotas[i] += nota;
                }
            }

            //for que imprime a nota final com a soma das notas por aluno
            for (int i = 0; i < qtdeAlunos; i++) {
                
                Console.WriteLine("NOTA FINAL DE " + a[i].Nome.ToUpper() + ": " + somaNotas[i]);

                //if que verifica se o aluno atingiu a media 60 e foi aprovado.
                if (somaNotas[i] < 60)
                {
                    Console.WriteLine("REPROVADO(A)! " +
                        "FALTARAM " + (60 - somaNotas[i]) + " PONTOS.");
                }
                else
                {
                    Console.WriteLine("APROVADO(A)!");
                }
            }

            
        }
    }
}
