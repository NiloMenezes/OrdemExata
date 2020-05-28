﻿using OrdemExata.Dominio.Contratos;
using OrdemExata.Dominio.Entidades;
using OrdemExata.Repositorio.Contexto;

namespace OrdemExata.Repositorio.Repositorios
{
    public class UsuarioRepositorio : BaseRepositorio<Usuario>, IUsuarioRepositorio
    {
        public UsuarioRepositorio(OrdemExataContexto ordemExataContexto) : base(ordemExataContexto)
        {
        }
    }
}
