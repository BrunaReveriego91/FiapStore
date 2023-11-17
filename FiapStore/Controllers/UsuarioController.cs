using FiapStore.Entity;
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
        public IActionResult ObterTodosUsuario()
        {
            return Ok(this.usuarioRepository.ObterTodos());
        }

        [HttpGet("obter-por-usuario-id/{id}")]
        public IActionResult ObterPorUsuarioId(int id)
        {
            return Ok(this.usuarioRepository.ObterPorId(id));
        }

        [HttpPost]
        public IActionResult CadastrarUsuario([FromBody] Usuario usuario)
        {
            this.usuarioRepository.Cadastrar(usuario);
            return Ok("Usuário criado com sucesso!");
        }

        [HttpPut]
        public IActionResult AlterarUsuario(Usuario usuario)
        {
            this.usuarioRepository.Alterar(usuario);
            return Ok("Usuário alterado com sucesso!");
        }

        [HttpDelete("{id}")]
        public IActionResult DeletarUsuario(int id)
        {
            this.usuarioRepository.Deletar(id);
            return Ok("Usuário deletado com sucesso!");
        }
    }
}
