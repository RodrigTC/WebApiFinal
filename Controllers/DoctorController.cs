using Microsoft.AspNetCore.Mvc;
using WebApi.Services;
using WebApi.Models;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace WebApi.Controllers
{
    [Route("Api/[Controller]")]
    [ApiController]
    public class DoctorController : Controller
    {
        private readonly IDoctor _doc;
        public DoctorController(IDoctor doc)
        {
            _doc = doc;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_doc.GetAllDoctores());
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var obj = _doc.GetDoctor(id);
            if (obj == null)
            {
                return NotFound("El doctor con el id: (" + id.ToString() + ") no existe");
            }
            else
            {
                return Ok(obj);
            }
        }
        [HttpPost("Agregar")]
        public IActionResult add(Doctor doctor)
        {
            _doc.add(doctor);
            return CreatedAtAction(nameof(add), doctor);
        }
        [HttpGet("Correo/{correo}")]
        public IActionResult BuscarPorCorreo(string correo)
        {
            var obj = _doc.GetDoctorByEmail(correo);
            if (obj == null)
            {
                return NotFound("El doctor con el correo: (" + correo + ") no existe");
            }
            else
            {
                return Ok(obj);
            }

        }
        [HttpGet("Especialidad/{id}")]
        public IActionResult BuscarPorEspecialidad(int id) 
        {
            return Ok(_doc.GetDoctorByEspecialidad(id));

        }
        [HttpDelete("DeleteD/{id}")]
        public IActionResult Delete(int id)
        {

            return Ok(_doc.GetDoctorByEspecialidad(id));
        }
    }
}
