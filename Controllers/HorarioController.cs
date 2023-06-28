using Microsoft.AspNetCore.Mvc;
using WebApi.Services;

namespace WebApi.Controllers
{
    [Route("Api/[Controller]")]
    [ApiController]
    public class HorarioController : Controller
    {
        private readonly IHorarios _hora;
        public HorarioController(IHorarios hora)
        {
            _hora = hora;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_hora.GetAllHorarios());
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var obj = _hora.GetHorario(id);
            if (obj == null)
            {
                return NotFound("El horario(" + id.ToString() + ") no existe");
            }
            else
            {
                return Ok(obj);
            }
        }
    }
}
