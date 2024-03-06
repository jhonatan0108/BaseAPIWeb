using EcommerceAPI.Comunes.Classes.Contracts.Ecommerce;
using EcommerceAPI.Dominio.Services.Ecommerce.Estados;
using EcommerceAPI.Dominio.Services.Ecommerce.Facturas;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacturaController : Controller
    {
        private readonly IFacturasService _facturaService;
        public FacturaController(IFacturasService facturasService)
        {
            _facturaService = facturasService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_facturaService.ObtenerFactura());
        }

        [HttpGet]
        [Route("[Action]/{id}")]
        public IActionResult GetbyId(int id)
        {
            FacturaContract factura = _facturaService.ObtenerFactura(id);
            if (factura != null)
            {
                return Ok(factura);
            }
            return BadRequest();
        }


        [HttpPost]
        [Route("[Action]")]
        public IActionResult Crear(FacturaContract contract)
        {
            FacturaContract factura = _facturaService.Crear(contract);
            if (factura != null)
            {
                return Ok(factura);
            }
            return BadRequest();
        }

        [HttpPost]
        [Route("facturaUpdate")]
        public IActionResult Update(FacturaContract contract)
        {
            FacturaContract factura = _facturaService.Update(contract);
            if (factura != null)
            {
                return Ok(factura);
            }
            return BadRequest();
        }

        [HttpDelete]
        [Route("[Action]/{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_facturaService.Delete(id));
        }
    }
}
