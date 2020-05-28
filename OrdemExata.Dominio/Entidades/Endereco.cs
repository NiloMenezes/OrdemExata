namespace OrdemExata.Dominio.Entidades
{
    public class Endereco : Entidade
    {
        public int Id { get; set; }
        public string CEP { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(CEP))
            {
                AdicionarCritica("Crítica - O CEP deve estar preenchido");
            }
        }
    }
}
