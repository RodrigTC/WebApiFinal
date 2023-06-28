using Microsoft.AspNetCore.Mvc;
using WebApi.Services;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("Api/[Controller]")]
    [ApiController]
    public class EspecialidadController : Controller
    {
        private readonly IEspecialidad _especialidad;
        public EspecialidadController(IEspecialidad esp)
        {
            _especialidad = esp;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_especialidad.GetAllEspecialidades());
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var obj = _especialidad.GetEspecialidad(id);
            if (obj == null)
            {
                return NotFound("La especialidad(" + id.ToString() + ") no existe");
            }
            else
            {
                return Ok(obj);
            }
        }
    }
}
