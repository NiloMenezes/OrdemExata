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

            //Utilizar o padrão Fluent
            builder
                .HasOne(p => p.Usuario);
            
            
        }
    }
}
