using EcommerceAPI.Comunes.Classes.Contracts.Ecommerce;
using EcommerceAPI.Dominio.Services.Ecommerce.Producto;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly IProductoService _productosService;

        public ProductoController(IProductoService productosService)
        {
            _productosService = productosService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_productosService.ObtenerProductos());
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_productosService.ObtenerProductos(id));
        }

        [HttpPost]
        [Route("CrearProducto")]
        public IActionResult Create(ProductoContract contract)
        {
            ProductoContract producto = _productosService.Crear(contract);
            if (producto == null)
            {
                return BadRequest();
            }
            return Ok(producto);
        }

        [HttpPut]
        [Route("ProductoUpdate")]
        public IActionResult Update(ProductoContract contract)
        {
            ProductoContract producto = _productosService.Update(contract);
            if (producto == null)
            {
                return BadRequest();
            }
            return Ok(producto);
        }

        [HttpDelete]
        [Route("[action]/{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_productosService.Delete(id));
        }
    }
}
