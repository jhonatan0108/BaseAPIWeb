using EcommerceAPI.Comunes.Classes.Contracts.Ecommerce;
using EcommerceAPI.Dominio.Services.Ecommerce.Estados;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstadoController : Controller
    {
        private readonly IEstadosService _estadosService;
        public EstadoController(IEstadosService estadosService)
        {
            _estadosService = estadosService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_estadosService.ObtenerEstado());
        }

        [HttpGet]
        [Route("[Action]/{id}")]
        public IActionResult GetbyId(int id)
        {
            EstadoContract estado = _estadosService.ObtenerEstado(id);
            if (estado != null)
            {
                return Ok(estado);
            }
            return BadRequest();
        }


        [HttpPost]
        [Route("[Action]")]
        public IActionResult Crear(EstadoContract contract)
        {
            EstadoContract estado = _estadosService.Crear(contract);
            if (estado != null)
            {
                return Ok(estado);
            }
            return BadRequest();
        }

        [HttpPost]
        [Route("estadoUpdate")]
        public IActionResult Update(EstadoContract contract)
        {
            EstadoContract estado = _estadosService.Update(contract);
            if (estado != null)
            {
                return Ok(estado);
            }
            return BadRequest();
        }

        [HttpDelete]
        [Route("[Action]/{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_estadosService.Delete(id));
        }
    }
}
