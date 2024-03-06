using EcommerceAPI.Comunes.Classes.Contracts.Ecommerce;
using EcommerceAPI.Dominio.Services.Ecommerce.DetalleFacturas;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetalleFacturaController : Controller
    {
        private readonly IDetalleFacturasService _detalleFacturaService;
        public DetalleFacturaController(IDetalleFacturasService detalleFacturaService)
        {
            _detalleFacturaService = detalleFacturaService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_detalleFacturaService.ObtenerDetalleFactura());
        }

        [HttpGet]
        [Route("[Action]/{id}")]
        public IActionResult GetbyId(int id)
        {
            DetalleFacturaContract detalleFactura = _detalleFacturaService.ObtenerDetalleFactura(id);
            if (detalleFactura != null)
            {
                return Ok(detalleFactura);
            }
            return BadRequest();
        }


        [HttpPost]
        [Route("[Action]")]
        public IActionResult Crear(DetalleFacturaContract contract)
        {
            DetalleFacturaContract detalleFactura = _detalleFacturaService.Crear(contract);
            if (detalleFactura != null)
            {
                return Ok(detalleFactura);
            }
            return BadRequest();
        }

        [HttpPost]
        [Route("DetalleFacturaUpdate")]
        public IActionResult Update(DetalleFacturaContract contract)
        {
            DetalleFacturaContract detalleFactura = _detalleFacturaService.Update(contract);
            if (detalleFactura != null)
            {
                return Ok(detalleFactura);
            }
            return BadRequest();
        }

        [HttpDelete]
        [Route("[Action]/{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_detalleFacturaService.Delete(id));
        }
    }
}
