namespace Course.Entities
{
    //Ele está herdando as informações que vem da classe Empregado
    class FuncionarioTerceirizado : Empregado
    {
        //Declarações da variável e uso do encapsulamento
        public double CobrancaAdicional { get; set; }
        //Construtor padrão 
        public FuncionarioTerceirizado()
        {
        }
        //Criação do construtor
        public FuncionarioTerceirizado(string nome, int horas, double valorPorHoras, double cobrancaAdicional)
            : base(nome, horas, valorPorHoras)
        {
            CobrancaAdicional = cobrancaAdicional;
        }

        //Override ele estende ou modifica uma implementação
        public override double Pagamento()
        {
            return base.Pagamento() + 1.1 * CobrancaAdicional;
        }
    }
}