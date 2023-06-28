using Microsoft.AspNetCore.Mvc;
using WebApi.Services;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("Api/[Controller]")]
    [ApiController]

    public class UsuarioController : Controller
    {
        private readonly IUsuario _usu;
        public UsuarioController(IUsuario usu)
        {
            _usu = usu;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_usu.GetAllUsuarios());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var obj = _usu.GetUsuario(id);
            if (obj == null)
            {
                return NotFound("El usuario(" + id.ToString() + ") no existe");
            }
            else
            {
                return Ok(obj);
            }
        }

        [HttpPost("Agregar")]
        public IActionResult add(Usuario usuario)
        {
            _usu.add(usuario);
            return CreatedAtAction(nameof(add), usuario);
        }

        [HttpPut("Modificar")]
        public IActionResult modificar(Usuario usu)
        {
            _usu.update(usu);
            return CreatedAtAction(nameof(modificar), usu);
        }

        [HttpDelete("Eliminar/{id}")]
        public IActionResult delete(int id)
        {
            _usu.delete(id);
            return NoContent();
        }

    }
}
