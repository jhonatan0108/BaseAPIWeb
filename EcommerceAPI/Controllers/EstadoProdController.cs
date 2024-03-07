using EcommerceAPI.Comunes.Classes.Contracts.Ecommerce;
using EcommerceAPI.Dominio.Services.Ecommerce.EstadoFact;
using EcommerceAPI.Dominio.Services.Ecommerce.EstadoProd;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstadoProdController : ControllerBase
    {
        private readonly IEstadoProdService _estadoProdService;

        public EstadoProdController(IEstadoProdService estadoProdService)
        {
            _estadoProdService = estadoProdService;
        }

        [HttpGet]
        [Route("[Action]")]
        public IActionResult Index()
        {
            return Ok(_estadoProdService.ObtenerEstadoProd());
        }

        [HttpGet]
        [Route("[Action]/{id}")]
        public IActionResult GetbyId(string id)
        {
            EstadoProdContract estadoprod = _estadoProdService.ObtenerEstadoProd(id);
            if (estadoprod != null)
                return Ok(estadoprod);
            else
            {
                return BadRequest();
            }

        }

        [HttpPost]
        [Route("[Action]")]
        public IActionResult Crear(EstadoProdContract contract)
        {
            EstadoProdContract estadoProd = _estadoProdService.Crear(contract);
            if (estadoProd == null)
            {
                return BadRequest();

            }
            return Ok(estadoProd);
        }


        [HttpPut]
        [Route("[Action]")]
        public IActionResult Update(EstadoProdContract contract)
        {
            EstadoProdContract estadoProd = _estadoProdService.Update(contract);
            if (estadoProd == null)
            {
                return BadRequest();

            }
            return Ok(estadoProd);

        }

        [HttpGet]
        [Route("[Action]/{id}")]
        public IActionResult Delete(string id)
        {
            return Ok(_estadoProdService.Delete(id));

        }

    }
}
