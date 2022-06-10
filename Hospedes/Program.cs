using System;

namespace Hospedes
{
    class Programa
    {
        static void Main(string[] args)
        {
            Cliente c = new Cliente();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("=============================");
            Console.WriteLine("= ALUGUEL MENSAL DE QUARTOS =");
            Console.WriteLine("=============================");
            Console.WriteLine(); Console.ResetColor();
            Console.Write("> NOME: "); c.nome = Console.ReadLine();
            Console.Write("> ENDEREÇO (R.XXXXXXXXX, NºXXXX): "); c.end = Console.ReadLine();
            Console.Write("> TELEFONE PARA CONTATO: "); c.tel = Console.ReadLine();
            Console.WriteLine();
            Console.Write(">>> Quantos meses pretende passar em nosso prédio? "); int periodo = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine();
            Console.WriteLine("...");
            Console.ReadLine();
            Console.WriteLine("AGUARDE, ESTAMOS PROCURANDO OS MELHORES QUARTOS PARA VOCÊ!");
            Console.ReadLine();
            Console.WriteLine("...");
            Console.ReadLine();
            Console.WriteLine("ENCONTRADO! QUARTO 201 DISPONÍVEL!");
            Console.WriteLine();
            Console.WriteLine(">> VALOR MENSAL: R$989,00");
            Console.WriteLine();
            Console.ResetColor();
            Console.Write("DESEJA ALUGAR ESTES 3 QUARTOS? (S/N) "); char resp = char.Parse(Console.ReadLine());

            if (resp == 's' || resp == 'S')
            {
                Console.Write("\nQUARTO");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(" 201 ");
                Console.ResetColor();
                Console.Write("ALUGADO! OBRIGADA PELA PREFERÊNCIA!");
                Console.WriteLine("\n");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("===============================================");
                Console.WriteLine("=               RELATÓRIO FINAL               =");
                Console.WriteLine("===============================================");
                Console.WriteLine("               NOME | " + c.nome.ToUpper());
                Console.WriteLine("           ENDEREÇO | " + c.end.ToUpper());
                Console.WriteLine("           TELEFONE | " + c.tel);
                Console.WriteLine("            QUARTOS | 201, 202 E 203");
                Console.WriteLine("VALOR TOTAL Á VISTA | " + c.ValorMensal(periodo).ToString("F2"));
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
