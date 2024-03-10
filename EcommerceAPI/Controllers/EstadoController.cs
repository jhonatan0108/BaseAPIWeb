using EcommerceAPI.Comunes.Clases.Contracts.Ecommerce;
using EcommerceAPI.Comunes.Classes.Contracts.Ecommerce;
using EcommerceAPI.Dominio.Services.Ecommerce.Estados;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstadoController : ControllerBase
    {
        private readonly IEstadoService _estadoService;

        public EstadoController(IEstadoService estadoService)
        {
            _estadoService = estadoService;
        }

        [HttpGet]
        [Route("[Action]")]
        public IActionResult GetAll()
        {
            return Ok(_estadoService.ObtenerEstados());

        }

        [HttpGet]
        [Route("[Action]/{id_estado}")]
        public IActionResult GetbyId(int id_estado)
        {
            EstadoContract estado = _estadoService.ObtenerEstado(id_estado);

            if (estado != null)
            {
                return Ok(estado);
            }
            else
            { return BadRequest(); }

        }

        [HttpPost]
        [Route("[Action]")]
        public IActionResult crearEstado(EstadoContract estado)
        {
            EstadoContract _estado = _estadoService.Crear(estado);

            if (_estado != null)
            {
                return Ok(_estado);
            }
            else
            { return BadRequest(); }

        }

        [HttpPut]
        [Route("[Action]")]
        public IActionResult UpdateEstado(EstadoContract estado)
        {
            EstadoContract _estado = _estadoService.Update(estado);

            if (_estado != null)
            {
                return Ok(_estado);
            }
            else
            { return BadRequest(); }


        }

        [HttpDelete]
        [Route("[Action]/{id_estado}")]
        public IActionResult eliminarEstado(int id_estado)
        {

            return Ok(_estadoService.Delete(id_estado));

        }
    }
}
