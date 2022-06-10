using System;
namespace HospedesVetor
{
    class Programa
    {
        static void Main(string[] args)
        {
            int quarto = 0;

            //introducao do programa

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("=============================");
            Console.WriteLine("= ALUGUEL MENSAL DE QUARTOS =");
            Console.WriteLine("=============================");
            Console.WriteLine(); Console.ResetColor();

            //define o limite de estudantes para o proximo for e vetor
            Console.WriteLine("Quantos estudantes irão alugar os quartos?"); int qtdeEstudantes = int.Parse(Console.ReadLine());

            Hospede[] c = new Hospede[qtdeEstudantes];

            for (int i = 0; i < qtdeEstudantes; i++)
            {
                Console.WriteLine("--------------HÓSPEDE " + (i + 1) + "--------------");
                Console.Write("> NOME: "); string nome = Console.ReadLine();
                Console.Write("> ENDEREÇO (R.XXXXXXXXX, NºXXXX): "); string end = Console.ReadLine();
                Console.Write("> TELEFONE PARA CONTATO: "); string tel = Console.ReadLine();
                Console.WriteLine("> TIPO DE QUARTO: (1-CASAL 2-SOLTEIRO 3-CASAL COM MAIS CAMAS)"); quarto = int.Parse(Console.ReadLine());

                c[i] = new Hospede(nome, end, tel, quarto);
            }

            Console.WriteLine();
            Console.Write(">>> Quantos meses pretende passar em nosso prédio? "); int periodo = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine();
            Console.WriteLine("...");
            Console.ReadLine();
            Console.WriteLine("AGUARDE, ESTAMOS PROCURANDO O(S) MELHORE(S) QUARTO(S) PARA VOCÊ!");
            Console.ReadLine();
            Console.WriteLine("...");
            Console.ReadLine();
            Console.WriteLine("QUARTOS DISPONÍVEIS ENCONTRADOS!");
            Console.WriteLine();
            Console.ResetColor();

            //pergunta se o usuario deseja mesmo alugar para mostrar os dados finais.
            Console.Write("DESEJA ALUGAR ESTE(S) QUARTO(S)? (S/N) "); char resp = char.Parse(Console.ReadLine());

            if (resp == 's' || resp == 'S')
            {
                Console.WriteLine("\nQUARTO(S) ALUGADO(S)! OBRIGADA PELA PREFERÊNCIA!");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("===============================================");
                Console.WriteLine("=               RELATÓRIO FINAL               =");
                Console.WriteLine("===============================================");
                for (int i = 0; i < qtdeEstudantes; i++)
                {
                    Console.WriteLine("                NOME | " + c[i].Nome.ToUpper());
                    Console.WriteLine("            ENDEREÇO | " + c[i].End.ToUpper());
                    Console.WriteLine("            TELEFONE | " + c[i].Tel);
                    Console.WriteLine("              QUARTO | 20" + (i + 1));
                    Console.WriteLine("               VALOR | " + c[i].ValorMensal(periodo).ToString("F2"));
                    Console.WriteLine("===============================================");
                }

                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\nVOLTE SEMPRE :)");
                Console.ResetColor();
            }
        }
    }
}
