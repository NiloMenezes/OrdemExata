﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OrdemExata.Dominio.Contratos
{
    public interface IBaseRepositorio<TEntity> : IDisposable where TEntity : class 
    {
        void Adicionar(TEntity entity);
        TEntity ObterPorId(string id);
        IEnumerable<TEntity> ObterTodos();
        void Atualizar(TEntity entity);
        void Remover(TEntity entity);
    }
}
