using EcommerceAPI.Comunes.Classes.Contracts.Ecommerce;
using EcommerceAPI.Dominio.Services.Ecommerce.Productos;
using EcommerceAPI.Infraestructura.Database.Entities;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly IProductosService _productosService;

        public ProductoController(IProductosService productosService)
        {
            _productosService = productosService;

        }
        [HttpGet]

        public IActionResult Get()
        {
            return Ok(_productosService.ObtenerProductos());
        }

        [HttpGet("{id}")]

        public IActionResult Get(int id)
        {
            return Ok(_productosService.BuscarProducto(id));

        }

        [HttpPut("{Producto}")]

        public IActionResult Put(ProductoContract contract)
        {
            return Ok(_productosService.ActualizarProducto(contract));
        }

        [HttpPost]

        public IActionResult Crear(ProductoContract contract)
        {
            return Ok(_productosService.CrearProducto(contract));

        }

        [HttpDelete("{id}")]

        public IActionResult BorrarProducto(int id)
        {
            return Ok(_productosService.BorrarProducto(id));
        }
    }
}
