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
            throw new System.NotImplementedException();
        }
    }
}
