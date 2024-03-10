using EcommerceAPI.Comunes.Clases.Contracts.Ecommerce;
using EcommerceAPI.Comunes.Classes.Contracts.Ecommerce;
using EcommerceAPI.Dominio.Services.Ecommerce.Productos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {

        private readonly IProductoService _productoService;

        public ProductoController(IProductoService productoService)
        {
            _productoService = productoService;
        }

        [HttpGet]
        [Route("[Action]")]
        public IActionResult GetAll()
        {
            return Ok(_productoService.ObtenerProductos());

        }

        [HttpGet]
        [Route("[Action]/{id_producto}")]
        public IActionResult GetbyId(int id_producto)
        {
            ProductoContract producto = _productoService.ObtenerProducto(id_producto);

            if (producto != null)
            {
                return Ok(producto);
            }
            else
            { return BadRequest(); }

        }

        [HttpPost]
        [Route("[Action]")]
        public IActionResult crearProducto(ProductoContract producto)
        {
            ProductoContract _producto = _productoService.Crear(producto);

            if (_producto != null)
            {
                return Ok(_producto);
            }
            else
            { return BadRequest(); }

        }

        [HttpPut]
        [Route("[Action]")]
        public IActionResult UpdateProducto(ProductoContract producto)
        {
            ProductoContract _producto = _productoService.Update(producto);

            if (_producto != null)
            {
                return Ok(_producto);
            }
            else
            { return BadRequest(); }

        }

        [HttpDelete]
        [Route("[Action]/{id_producto}")]
        public IActionResult eliminarProducto(int id_producto)
        {

            return Ok(_productoService.Delete(id_producto));

        }
    }
}
