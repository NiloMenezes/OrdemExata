using OrdemExata.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;

namespace OrdemExata.Dominio.Entidades
{
    public class Pedido
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
    }
}
