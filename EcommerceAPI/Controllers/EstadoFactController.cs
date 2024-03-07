using EcommerceAPI.Comunes.Classes.Contracts.Ecommerce;
using EcommerceAPI.Dominio.Services.Ecommerce.EstadoFact;
using EcommerceAPI.Dominio.Services.Ecommerce.Productos;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controllers
{
    [Route("api/Estado Factura")]
    [ApiController]
    public class EstadoFactController : ControllerBase
    {
        private readonly IEstadoFactService _estadoFactService;

        public EstadoFactController(IEstadoFactService estadoFactService)
        {
            _estadoFactService = estadoFactService;
        }

        [HttpGet]
        [Route("[Action]")]
        public IActionResult Index()
        {
            return Ok(_estadoFactService.ObtenerEstadoFacts());
        }

        [HttpGet]
        [Route("[Action]/{id}")]
        public IActionResult GetbyId(string id)
        {
            EstadoFactContract estadofact = _estadoFactService.ObtenerEstadoFact(id);
            if (estadofact != null)
                return Ok(estadofact);
            else
            {
                return BadRequest();
            }

        }

        [HttpPost]
        [Route("[Action]")]
        public IActionResult Crear(EstadoFactContract contract)
        {
            EstadoFactContract estadoFact = _estadoFactService.Crear(contract);
            if (estadoFact == null)
            {
                return BadRequest();

            }
            return Ok(estadoFact);
        }
            

        [HttpPut]
        [Route("[Action]")]
        public IActionResult Update(EstadoFactContract contract)
        {
            EstadoFactContract estadoFact = _estadoFactService.Update(contract);
            if (estadoFact == null)
            {
                return BadRequest();

            }
            return Ok(estadoFact);
            
        }

        [HttpGet]
        [Route("[Action]/{id}")]
        public IActionResult Delete(string id)
        {
            return Ok(_estadoFactService.Delete(id));

        }

    }
}
