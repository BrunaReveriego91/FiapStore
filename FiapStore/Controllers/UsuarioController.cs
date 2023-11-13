using FiapStore.Entidade;
using FiapStore.Interface;
using Microsoft.AspNetCore.Mvc;

namespace FiapStore.Controllers
{
    [ApiController]
    [Route("Usuario")]
    public class UsuarioController : ControllerBase
    {
        private IUsuarioRepository usuarioRepository;

        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            this.usuarioRepository = usuarioRepository;
        }


        [HttpGet("obter-todos-usuario")]
        public IActionResult ObterUsuario()
        {
            return Ok(this.usuarioRepository.ObterTodosUsuarios());
        }

        [HttpGet("obter-por-usuario-id/{id}")]
        public IActionResult ObterPorUsuarioId(int id)
        {
            return Ok(this.usuarioRepository.ObterUsuarioPorId(id));
        }

        [HttpPost]
        public IActionResult CadastrarUsuario([FromBody] Usuario usuario)
        {
            this.usuarioRepository.CadastrarUsuario(usuario);
            return Ok("Usuário criado com sucesso!");
        }

        [HttpPut]
        public IActionResult AlterarUsuario()
        {
            return Ok("Usuário alterado com sucesso!");
        }

        [HttpDelete]
        public IActionResult DeletarUsuario()
        {
            return Ok("Usuário deletado com sucesso!");
        }
    }
}
