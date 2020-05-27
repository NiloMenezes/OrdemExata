using Microsoft.EntityFrameworkCore;
using OrdemExata.Dominio.Entidades;
using OrdemExata.Dominio.ObjetoDeValor;
using OrdemExata.Repositorio.Config;

namespace OrdemExata.Repositorio.Contexto
{
    public class OrdemExataContexto : DbContext
    {

        //Configurar todos DbSet para todas as classes
        //Os nome 'Usuarios', 'Fornecedores', 'Pedidos' são os mesmos nomes nas tabelas do banco de dados
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<FormaPagamento> FormasPagamento { get; set; }
        //Fazer com todos
        
        public OrdemExataContexto(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Classes de mapeamento
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new FornecedorConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
