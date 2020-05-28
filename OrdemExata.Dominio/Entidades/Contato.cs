namespace OrdemExata.Dominio.Entidades
{
    public class Contato : Entidade
    {
        public int Id { get; set; }
        public string Email { get; set; }
        //public int ContatoId { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Email))
            {
                AdicionarCritica("Email não foi informado");
            }
        }
    }
}
