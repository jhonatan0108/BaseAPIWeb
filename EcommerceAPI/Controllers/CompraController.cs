using EcommerceAPI.Comunes.Classes.Contracts.Ecommerce;
using EcommerceAPI.Dominio.Services.Ecommerce.Compras;
using EcommerceAPI.Infraestructura.Database.Entities;
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

        public IActionResult Get()
        {
            return Ok(_compraService.ObtenerCompra());
        }

        [HttpGet("{id}")]

        public IActionResult Get(Int32 id)
        {
            return Ok(_compraService.BuscarCompra(id));

        }

        [HttpPut("{Compra}")]

        public IActionResult Put(CompraContract contract)
        {
            return Ok(_compraService.ActualizarCompra(contract));
        }

        [HttpPost]

        public IActionResult Crear(CompraContract contract)
        {
            return Ok(_compraService.CrearCompra(contract));

        }

        [HttpDelete("{id}")]

        public IActionResult BorrarCompra(Int32 id)
        {
            return Ok(_compraService.BorrarCompra(id));
        }
    }
}
