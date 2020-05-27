namespace OrdemExata.Dominio.Entidades
{
    public class Contato : Entidade
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Telefone))
            {
                AdicionarCritica("Telefone não foi informado");
            }
        }
    }
}
