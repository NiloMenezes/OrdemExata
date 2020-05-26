using System.Collections.Generic;
using System.Linq;

namespace OrdemExata.Dominio.Entidades
{
    public abstract class Entidade
    {
        //Implementação das regras do negócio.
        public List<string> _mensagemValidacao { get; set; }
        private List<string> mensagemValidacao 
        {
            //É uma propriedade de SOMENTE LEITURA, logo NÃO tem SET

            /* Se _mensagemValidacao estiver vazia retorna uma instancia sem elementos
             * Se _mensagemValidacao não estiver vazia retorna _mensagemValidacao
             */

            get { return _mensagemValidacao ?? (_mensagemValidacao = new List<string>()); }
        }

        protected void LimparMensagemValidacao() 
        {
            mensagemValidacao.Clear();
        }

        protected void AdicionarCritica(string mensagem) 
        {
            mensagemValidacao.Add(mensagem);
        }

        public abstract void Validate();

        protected bool EhValido 
        {
            //Se não tiver nenhuma mensagem de validação a classe é VALIDA
            get { return !mensagemValidacao.Any(); }
        }
    }
}
