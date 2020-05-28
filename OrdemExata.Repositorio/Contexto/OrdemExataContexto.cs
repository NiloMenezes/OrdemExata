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
        public DbSet<Pedido> Pedidos { get; set; }
        
        public OrdemExataContexto(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Classes de mapeamento
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new PedidoConfiguration());


            ////Aplicar as classes de configuração (OrdemExtra.Dominio -> ObjetosDeValor), mas pode fazer também com classes
            ////.HasData -> 'Têm dados'
            //modelBuilder.Entity<FormaPagamento>().HasData(
            //    new FormaPagamento() { Id = 1, Nome = "Boleto", Descricao = "Forma de Pagamento Boleto" },
            //    new FormaPagamento() { Id = 2, Nome = "Cartão de Crédito", Descricao = "Forma de Pagamento Cartão de Crédito" },
            //    new FormaPagamento() { Id = 3, Nome = "Depósito", Descricao = "Forma de Pagamento Depósito" });
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
