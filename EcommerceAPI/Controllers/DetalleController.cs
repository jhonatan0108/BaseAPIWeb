using EcommerceAPI.Comunes.Clases.Contracts.Ecommerce;
using EcommerceAPI.Comunes.Classes.Contracts.Ecommerce;
using EcommerceAPI.Dominio.Services.Ecommerce.Clientes;
using EcommerceAPI.Dominio.Services.Ecommerce.DetalleCompra;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetalleController : ControllerBase
    {
        private readonly IDetalleService _detalleService;
        public DetalleController(IDetalleService detalleService)
        {

            _detalleService = detalleService;

        }

        [HttpGet]
        [Route("[Action]")]
        public IActionResult GetAll()
        {
            return Ok(_detalleService.ObtenerDetalleCompras());

        }

        [HttpGet]
        [Route("[Action]/{id_detallecompra}")]
        public IActionResult GetbyId(int id_detallecompra)
        {
            DetalleContract detalle = _detalleService.ObtenerDetalleCompra(id_detallecompra);

            if (detalle != null)
            {
                return Ok(detalle);
            }
            else
            { return BadRequest(); }

        }

        [HttpPost]
        [Route("[Action]")]
        public IActionResult crearDetalleCompra(DetalleContract detalle)
        {
            DetalleContract _detalle = _detalleService.Crear(detalle);

            if (_detalle != null)
            {
                return Ok(_detalle);
            }
            else
            { return BadRequest(); }

        }

        [HttpPut]
        [Route("[Action]")]
        public IActionResult UpdateDetalleCompra(DetalleContract detalle)
        {
            DetalleContract _detalle = _detalleService.Update(detalle);

            if (_detalle != null)
            {
                return Ok(_detalle);
            }
            else
            { return BadRequest(); }

        }

        [HttpDelete]
        [Route("[Action]/{id_detallecompra}")]
        public IActionResult eliminarDetalleCompra(int id_detallecompra)
        {

            return Ok(_detalleService.Delete(id_detallecompra));

        }
    }
}
