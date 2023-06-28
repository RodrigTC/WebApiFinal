using Microsoft.AspNetCore.Mvc;
using WebApi.Models;
using WebApi.Services;

namespace WebApi.Controllers
{
    [Route("Api/[Controller]")]
    [ApiController]
    public class CitaController : Controller
    {
        private readonly ICita _cita;
        public CitaController(ICita citum)
        {
            _cita = citum;
        }
        [HttpGet()]
        public IActionResult Get()
        {
            return Ok(_cita.GetAllCitas());
        }
        [HttpGet("Doctor/{idoc}")]
        public IActionResult GetD(int idoc)
        {
            return Ok(_cita.GetCitasDoc(idoc));
        }
        [HttpGet("Usuario/{idusu}")]
        public IActionResult GetU(int idusu)
        { 
               return Ok(_cita.GetCitasUsu(idusu));
        }
        [HttpPost("Agregar")]
        public IActionResult add(Citum cita)
        {
            _cita.add(cita);
            return CreatedAtAction(nameof(add), cita);
        }
        [HttpDelete("Eliminar/{id}")]
        public IActionResult delete(int id)
        {
            _cita.delete(id);
            return NoContent();
        }


    }
}

