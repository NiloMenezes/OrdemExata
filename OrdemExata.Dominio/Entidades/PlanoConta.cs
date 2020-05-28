namespace OrdemExata.Dominio.Entidades
{
    public class PlanoConta : Entidade
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int Conta { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Descricao))
            {
                AdicionarCritica("Crítica - O descricao deve estar preenchido");
            }
        }
    }
}
