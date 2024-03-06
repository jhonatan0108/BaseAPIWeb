using EcommerceAPI.Comunes.Classes.Contracts.Ecommerce;
using EcommerceAPI.Dominio.Services.Ecommerce.Compra;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompraController : ControllerBase
    {
        private readonly ICompraService _comprasService;

        public CompraController(ICompraService comprasService)
        {
            _comprasService = comprasService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_comprasService.ObtenerCompra());
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_comprasService.ObtenerCompra(id));
        }

        [HttpPost]
        [Route("CrearCompra")]
        public IActionResult Create(CompraContract contract)
        {
            CompraContract compra = _comprasService.Crear(contract);
            if (compra == null)
            {
                return BadRequest();
            }
            return Ok(compra);
        }

        [HttpPut]
        [Route("CompraUpdate")]
        public IActionResult Update(CompraContract contract)
        {
            CompraContract compra = _comprasService.Update(contract);
            if (compra == null)
            {
                return BadRequest();
            }
            return Ok(compra);
        }

        [HttpDelete]
        [Route("[action]/{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_comprasService.Delete(id));
        }
    }
}