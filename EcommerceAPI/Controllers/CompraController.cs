using EcommerceAPI.Comunes.Clases.Contracts.Ecommerce;
using EcommerceAPI.Comunes.Classes.Contracts.Ecommerce;
using EcommerceAPI.Dominio.Services.Ecommerce.Compra;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompraController : ControllerBase
    {
        private readonly ICompraService _compraService;

        public CompraController(ICompraService compraService)
        {
            _compraService = compraService;
        }


        [HttpGet]
        [Route("[Action]")]
        public IActionResult GetAll()
        {
            return Ok(_compraService.ObtenerCompras());

        }

        [HttpGet]
        [Route("[Action]/{id_compra}")]
        public IActionResult GetbyId(int id_compra)
        {
            CompraContract compra = _compraService.ObtenerCompra(id_compra);

            if (compra != null)
            {
                return Ok(compra);
            }
            else
            { return BadRequest(); }

        }

        [HttpPost]
        [Route("[Action]")]
        public IActionResult crearCompra(CompraContract compra)
        {
            CompraContract _compra = _compraService.Crear(compra);

            if (_compra != null)
            {
                return Ok(_compra);
            }
            else
            { return BadRequest(); }

        }

        [HttpPut]
        [Route("[Action]")]
        public IActionResult UpdateCompra(CompraContract compra)
        {
            CompraContract _compra = _compraService.Update(compra);

            if (_compra != null)
            {
                return Ok(_compra);
            }
            else
            { return BadRequest(); }

        }

        [HttpDelete]
        [Route("[Action]/{id_compra}")]
        public IActionResult eliminarCompra(int id_compra)
        {

            return Ok(_compraService.Delete(id_compra));

        }
    }
}
