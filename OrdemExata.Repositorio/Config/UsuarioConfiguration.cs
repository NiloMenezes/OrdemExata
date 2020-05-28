using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrdemExata.Dominio.Entidades;

namespace OrdemExata.Repositorio.Config
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            //Usa a letra u porque é a primeira letra de Usuario
            builder.HasKey(u => u.Id); //Chave primária 
            
            //Utilizar o padrão Fluent
            builder
                .Property(u => u.Nome)
                .IsRequired()
                .HasMaxLength(20);

            builder
                .Property(u => u.Sobrenome)
                .IsRequired()
                .HasMaxLength(50);
                //.HasColumnType("varchar");

            builder
                .Property(u => u.Senha)
                .IsRequired()
                .HasMaxLength(400); //Senha criptografada

            builder
                .HasMany(u => u.Pedidos)
                .WithOne(p => p.Usuario);

            //builder
            //    .Property(u => u.Data)
            //    .IsRequired();
        }
    }
}
