namespace OrdemExata.Dominio.Entidades
{
    public class Telefone : Entidade
    {
        public int Id { get; set; }
        public string Operadora { get; set; }
        public string Numero { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Operadora))
            {
                AdicionarCritica("Crítica - O operadora deve estar preenchido");
            }
        }
    }
}
