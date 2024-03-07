using EcommerceAPI.Comunes.Classes.Contracts.Ecommerce;
using EcommerceAPI.Dominio.Services.Ecommerce.Factura;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controllers
{
    [Route("api/Factura")]
    [ApiController]
    public class FacturaController : ControllerBase
    {
        private readonly IFacturaService _facturaService;

        public FacturaController(IFacturaService facturaService)
        {
            _facturaService = facturaService;
        }

        [HttpGet]
        [Route("[Action]")]
        public IActionResult Index()
        {
            return Ok(_facturaService.ObtenerFactura());
        }

        [HttpGet]
        [Route("[Action]/{id}")]
        public IActionResult GetbyId(string id)
        {
            FacturaContract factura = _facturaService.ObtenerFactura(id);
            if (factura != null)
                return Ok(factura);
            else
            {
                return BadRequest();
            }

        }

        [HttpPost]
        [Route("[Action]")]
        public IActionResult Crear(FacturaContract contract)
        {
            FacturaContract factura = _facturaService.Crear(contract);
            if (factura == null)
            {
                return BadRequest();

            }
            return Ok(factura);
        }


        [HttpPut]
        [Route("[Action]")]
        public IActionResult Update(FacturaContract contract)
        {
            FacturaContract factura = _facturaService.Update(contract);
            if (factura == null)
            {
                return BadRequest();

            }
            return Ok(factura);

        }

        [HttpGet]
        [Route("[Action]/{id}")]
        public IActionResult Delete(string id)
        {
            return Ok(_facturaService.Delete(id));

        }
    }
}
