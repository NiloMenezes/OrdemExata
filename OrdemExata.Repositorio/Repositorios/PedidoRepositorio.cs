using OrdemExata.Dominio.Contratos;
using OrdemExata.Dominio.Entidades;
using OrdemExata.Repositorio.Contexto;

namespace OrdemExata.Repositorio.Repositorios
{
    public class PedidoRepositorio : BaseRepositorio<Pedido>, IPedidoRepositorio
    {
        public PedidoRepositorio(OrdemExataContexto ordemExataContexto) : base(ordemExataContexto)
        {
        }
    }
}
