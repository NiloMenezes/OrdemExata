using OrdemExata.Dominio.Contratos;
using OrdemExata.Repositorio.Contexto;
using System.Collections.Generic;
using System.Linq;

namespace OrdemExata.Repositorio.Repositorios
{
    public class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity : class
    {

        //metodo somente leitura
        protected readonly OrdemExataContexto OrdemExataContexto;

        //ct tab tab
        public BaseRepositorio(OrdemExataContexto ordemExataContexto)
        {
            OrdemExataContexto = ordemExataContexto;
        }
        public void Adicionar(TEntity entity)
        {
            OrdemExataContexto.Set<TEntity>().Add(entity);
            OrdemExataContexto.SaveChanges();
        }

        public TEntity ObterPorId(string id)
        {
            return OrdemExataContexto.Set<TEntity>().Find(id);
        }
        public IEnumerable<TEntity> ObterTodos()
        {
            return OrdemExataContexto.Set<TEntity>().ToList();
        }
        public void Atualizar(TEntity entity)
        {
            OrdemExataContexto.Set<TEntity>().Update(entity);
            OrdemExataContexto.SaveChanges();
        }
        public void Remover(TEntity entity)
        {
            OrdemExataContexto.Remove(entity);
            OrdemExataContexto.SaveChanges();
        }

        //Serve para descartar o BaseRepositorio da memória
        public void Dispose()
        {
            OrdemExataContexto.Dispose();
        }
    }
}
