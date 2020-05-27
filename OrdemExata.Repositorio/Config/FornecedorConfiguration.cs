using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrdemExata.Dominio.Entidades;

namespace OrdemExata.Repositorio.Config
{
    public class FornecedorConfiguration : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            throw new System.NotImplementedException();
        }
    }
}
