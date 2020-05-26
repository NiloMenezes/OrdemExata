using OrdemExata.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OrdemExata.Dominio.Entidades
{
    public class Pedido : Entidade
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public DateTime DataEntrega { get; set; }
        public int CaixaId { get; set; }
        public int UsuarioId { get; set; }
        public int FornecedorID { get; set; }


        public int FormaPagamentoId { get; set; }
        public FormaPagamento FormaPagamento { get; set; }

        /// <summary>
        /// Pedido deve ter 1 ou muitos item(ns) de pedido(s)
        /// </summary>
        public ICollection<ItemPedido> ItensPedidos { get; set; }


        //Coloca TODAS as regras do negócio
        public override void Validate()
        {
            LimparMensagemValidacao();

            //Um pedido NÃO pode ter nenhum item, logo a classe ItensPedidos não pode ser vazia
            if (!ItensPedidos.Any()) 
            {
                AdicionarCritica("Critica - Pedido não pode ficar sem itens de pedido");
            }

            //if (CaixaId == 0)
            //{
            //    AdicionarCritica("Erro - Deve ser informado o caixa que será pago o pedido");
            //}
        }
    }
}
