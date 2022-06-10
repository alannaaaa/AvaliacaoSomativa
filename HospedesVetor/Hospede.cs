namespace HospedesVetor
{
    class Hospede
    {
        public string Nome { get; set; }
        public string End { get; set; }
        public string Tel { get; set; }

        public int Quarto { get; set; }

        public double precoQuarto;
        public double ValorMensal(int periodo)
        {
            return periodo * precoQuarto;
        }

        public Hospede(string nome, string end, string tel, int quarto)
        {
            Nome = nome;
            End = end;
            Tel = tel;
            Quarto = quarto;

            //verifica qual opcao o cliente escolheu e define o preco do quarto escolhido.
            if (quarto == 1)
            {
                precoQuarto = 989.0;
            }
            else if (quarto == 2)
            {
                precoQuarto = 1050.0;
            }
            else
            {
                precoQuarto = 1500.0;
            }
        }
    }
}
