namespace Salarios
{
    class Pessoa
    {
        public string nome;
        public float salarioBruto, aumento, imposto;

        public float salarioLiquido()
        {
            imposto = 100;
            return salarioBruto - imposto;
        }

        public float salarioBrutoAumentado()
        {
            imposto = 100;
            return salarioBruto + (salarioBruto * aumento / 100) - imposto;
        }
    }
}
