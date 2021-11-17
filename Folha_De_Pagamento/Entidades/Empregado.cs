namespace Course.Entities
{
    class Empregado
    {
        //variáveis
        public string Nome { get; set; }
        public int Horas { get; set; }
        public double ValorPorHoras { get; set; }
        //Construtor padrão
        public Empregado()
        {
        }
        // Construtor
        public Empregado(string nome, int horas, double valorPorHoras)
        {
            Nome = nome;
            Horas = horas;
            ValorPorHoras = valorPorHoras;
        }
        //Virtual é usada para modificar uma declaração de método, propriedade
        public virtual double Pagamento()
        {
            return Horas * ValorPorHoras;
        }
    }
}