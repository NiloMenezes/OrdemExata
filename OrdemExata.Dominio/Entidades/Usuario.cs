//Limpar os using Ctrl+R e Ctrl+G
using System.Collections.Generic;

namespace OrdemExata.Dominio.Entidades
{
    public class Usuario : Entidade
    {
        //pr tab tab
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public int ContatoId { get; set; }
        public int EnderecoId { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }

        // colocar 3 barras ///
        /// <summary>
        /// Um usuário pode ter 0 ou muitos pedidos.
        /// </summary>
        public virtual ICollection<Pedido> Pedidos { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Nome))
            {
                AdicionarCritica("Crítica - O nome deve estar preenchido");
            }
            if (string.IsNullOrEmpty(Login))
            {
                AdicionarCritica("Crítica - O login deve estar preenchido");
            }
            if (string.IsNullOrEmpty(Senha))
            {
                AdicionarCritica("Crítica - A senha deve estar preenchido");
            }
        }
    }
}
