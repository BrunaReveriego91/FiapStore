using FiapStore.DTO;
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
        private readonly ILogger<UsuarioController> logger;

        public UsuarioController(IUsuarioRepository usuarioRepository,
                                 ILogger<UsuarioController> logger)
        {
            this.usuarioRepository = usuarioRepository;
            this.logger = logger;
        }

        [HttpGet("obter-todos-com-pedidos/{id}")]
        public IActionResult ObterTodosComPedidos(int id)
        {
            return Ok(this.usuarioRepository.ObterComPedidos(id));
        }


        [HttpGet("obter-todos-usuario")]
        public IActionResult ObterTodosUsuario()
        {
            this.logger.LogInformation("Executando método ObterTodosUsuario");
            return Ok(this.usuarioRepository.ObterTodos());
        }

        [HttpGet("obter-por-usuario-id/{id}")]
        public IActionResult ObterPorUsuarioId(int id)
        {
            return Ok(this.usuarioRepository.ObterPorId(id));
        }

        [HttpPost]
        public IActionResult CadastrarUsuario([FromBody] CadastrarUsuarioDTO usuarioDto)
        {
            this.usuarioRepository.Cadastrar(new Usuario(usuarioDto));
            return Ok("Usuário criado com sucesso!");
        }

        [HttpPut]
        public IActionResult AlterarUsuario([FromBody] AlterarUsuarioDTO usuarioDto)
        {
            this.usuarioRepository.Alterar(new Usuario(usuarioDto));
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
