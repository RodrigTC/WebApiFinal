using Microsoft.AspNetCore.Mvc;
using WebApi.Services;

namespace WebApi.Controllers
{
    [Route("Api/[Controller]")]
    [ApiController]
    public class DiaController : Controller
    {
        private readonly IDia _dia;

        public DiaController(IDia dia)
        {
            _dia = dia;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_dia.GetAllDias());
        }
        [HttpGet("{idia}")]
        public IActionResult GetDia(int idia)
        {
            return Ok(_dia.GetDiumById(idia));
        }

    }
}
