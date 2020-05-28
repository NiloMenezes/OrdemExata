using Microsoft.AspNetCore.Mvc;
using OrdemExata.Dominio.Contratos;
using OrdemExata.Dominio.Entidades;
using System;

namespace OrdemExata.Web.Controllers
{
    [Route("api/[Controller]")]
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        public UsuarioController(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        [HttpGet]
        public IActionResult Get() 
        {
            try
            {
                return Ok(_usuarioRepositorio.ObterTodos());

                //if (condicao)
                //    return BadRequest("Mensagem de erro");
            }
            catch (Exception ex) 
            {
                return BadRequest(ex.ToString());
            }
        }


        //[FromBody] -> Transforma a informação que veio como json do corpo da requisição em um objeto Usuario
        [HttpPost]
        public IActionResult Post([FromBody]Usuario usuario) 
        {
            try 
            {
                _usuarioRepositorio.Adicionar(usuario);
                return Created("api/usuario", usuario);
            } 
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
