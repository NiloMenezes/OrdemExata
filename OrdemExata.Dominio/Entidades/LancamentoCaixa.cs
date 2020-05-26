using System;
using System.Xml.Schema;

namespace OrdemExata.Dominio.Entidades
{
    public class LancamentoCaixa
    {
        public int Id { get; set; }
        //public Usuario Usuario { get; set; }
        public string Descriacao { get; set; }
        public decimal  ValorRecebido { get; set; }
        public decimal ValorAReceber { get; set; }
        public DateTime DataRecebido { get; set; }
        public DateTime DataAReceber { get; set; }
        public int TipoLancamento { get; set; }
        //public PlanoConta PlanoConta { get; set; }
        //public Caixa Caixa { get; set; }
        public string Observacao { get; set; }
        public string Periodicidade { get; set; }
        public int Repeticao { get; set; }








    }
}
