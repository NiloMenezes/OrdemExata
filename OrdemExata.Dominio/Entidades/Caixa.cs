namespace OrdemExata.Dominio.Entidades
{
    public class Caixa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Conta { get; set; }
        public string Agencia { get; set; }
        public decimal Valor { get; set; }

    }
}
