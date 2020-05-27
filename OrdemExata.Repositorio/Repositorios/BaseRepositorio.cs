using OrdemExata.Dominio.Contratos;
using System.Collections.Generic;

namespace OrdemExata.Repositorio.Repositorios
{
    public class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity : class
    {
        //ct tab tab
        public BaseRepositorio()
        {

        }
        public void Adicionar(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public TEntity ObterPorId(string id)
        {
            throw new System.NotImplementedException();
        }
        public IEnumerable<TEntity> ObterTodos()
        {
            throw new System.NotImplementedException();
        }
        public void Atualizar(TEntity entity)
        {
            throw new System.NotImplementedException();
        }
        public void Remover(TEntity entity)
        {
            throw new System.NotImplementedException();
        }
        public void Dispose()
        {
            throw new System.NotImplementedException();
        }
    }
}
