using OrdemExata.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrdemExata.Dominio.Contratos
{
    public interface IUsuarioRepositorio : IBaseRepositorio<Usuario>
    {
        Usuario Obter(string login, string senha);
    }
}
