namespace OrdemExata.Dominio.Entidades
{
    public class Caixa : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Conta { get; set; }
        public string Agencia { get; set; }
        public decimal Valor { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Nome))
            {
                AdicionarCritica("Crítica - O nome deve estar preenchido");
            }
        }
    }
}
