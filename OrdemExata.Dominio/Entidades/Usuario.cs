//Limpar os using Ctrl+R e Ctrl+G
using System.Collections.Generic;

namespace OrdemExata.Dominio.Entidades
{
    public class Usuario
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
        public ICollection<Pedido> Pedidos { get; set; }
    }
}
