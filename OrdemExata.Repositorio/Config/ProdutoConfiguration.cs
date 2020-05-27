using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrdemExata.Dominio.Entidades;

namespace OrdemExata.Repositorio.Config
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(p => p.Id);

            builder
                .Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(20);
            
            builder
                .Property(p => p.Descricao)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnType("varchar");

            builder
                .Property(p => p.Preco)
                .IsRequired();
        }
    }
}
