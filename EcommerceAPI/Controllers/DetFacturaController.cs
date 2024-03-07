using EcommerceAPI.Comunes.Classes.Contracts.Ecommerce;
using EcommerceAPI.Dominio.Services.Ecommerce.DeFactura;
using EcommerceAPI.Dominio.Services.Ecommerce.Factura;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetFacturaController : ControllerBase
    {
        private readonly IDetFacturaService _detfacturaService;

        public DetFacturaController(IDetFacturaService detfacturaService)
        {
            _detfacturaService = detfacturaService;
        }

        [HttpGet]
        [Route("[Action]")]
        public IActionResult Index()
        {
            return Ok(_detfacturaService.ObtenerDetFactura());
        }

        [HttpGet]
        [Route("[Action]/{id}")]
        public IActionResult GetbyId(string id)
        {
            DetFacturaContract detfactura = _detfacturaService.ObtenerDetFactura(id);
            if (detfactura != null)
                return Ok(detfactura);
            else
            {
                return BadRequest();
            }

        }

        [HttpPost]
        [Route("[Action]")]
        public IActionResult Crear(DetFacturaContract contract)
        {
            DetFacturaContract detfactura = _detfacturaService.Crear(contract);
            if (detfactura == null)
            {
            return BadRequest();

            }
            return Ok(detfactura);
        }


        [HttpPut]
        [Route("[Action]")]
        public IActionResult Update(DetFacturaContract contract)
        {
            DetFacturaContract detfactura = _detfacturaService.Update(contract);
            if (detfactura == null)
            {
            return BadRequest();

            }
            return Ok(detfactura);

        }

        [HttpGet]
        [Route("[Action]/{id}")]
        public IActionResult Delete(string id)
        {
            return Ok(_detfacturaService.Delete(id));

        }

    }
}
