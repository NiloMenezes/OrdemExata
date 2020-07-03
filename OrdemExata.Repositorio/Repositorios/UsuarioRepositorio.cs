using OrdemExata.Dominio.Contratos;
using OrdemExata.Dominio.Entidades;
using OrdemExata.Repositorio.Contexto;
using System.Linq;

namespace OrdemExata.Repositorio.Repositorios
{
    public class UsuarioRepositorio : BaseRepositorio<Usuario>, IUsuarioRepositorio
    {
        public UsuarioRepositorio(OrdemExataContexto ordemExataContexto) : base(ordemExataContexto)
        {

        }

        public Usuario Obter(string login, string senha)
        {
            return OrdemExataContexto.Usuarios.FirstOrDefault(u => u.Login == login && u.Senha == senha);
        }
    }
}
