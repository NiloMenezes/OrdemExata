namespace OrdemExata.Dominio.Entidades
{
    public class PlanoConta : Entidade
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int Conta { get; set; }

        public override void Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}
