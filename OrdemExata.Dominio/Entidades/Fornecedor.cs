namespace OrdemExata.Dominio.Entidades
{
    public class Fornecedor : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Identificacao{ get; set; } //CPF ou CNPJ
        public string Descicao { get; set; }
        public string Contato { get; set; }
        //public int EnderecoId { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Nome))
            {
                AdicionarCritica("Crítica - O nome deve estar preenchido");
            }
        }
    }
}
