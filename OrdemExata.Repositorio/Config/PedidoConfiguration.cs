using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrdemExata.Dominio.Entidades;

namespace OrdemExata.Repositorio.Config
{
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(p => p.Id);


            ////Para cada pedido uma unica forma de pagamento
            //builder
            //    .HasOne(p => p.FormaPagamento);
        }
    }
}
