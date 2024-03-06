using EcommerceAPI.Comunes.Classes.Contracts.Ecommerce;
using EcommerceAPI.Dominio.Services.Ecommerce.Productos;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : Controller
    {
        private readonly IProductosService _productosService;
        public ProductoController(IProductosService productosService)
        {
            _productosService = productosService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_productosService.ObtenerProducto());
        }

        [HttpGet]
        [Route("[Action]/{id}")]
        public IActionResult GetbyId(int id)
        {
            ProductoContract producto = _productosService.ObtenerProducto(id);
            if (producto != null)
            {
                return Ok(producto);
            }
            return BadRequest();
        }


        [HttpPost]
        [Route("[Action]")]
        public IActionResult Crear(ProductoContract contract)
        {
            ProductoContract producto = _productosService.Crear(contract);
            if (producto != null)
            {
                return Ok(producto);
            }
            return BadRequest();
        }

        [HttpPost]
        [Route("ProductoUpdate")]
        public IActionResult Update(ProductoContract contract)
        {
            ProductoContract producto = _productosService.Update(contract);
            if (producto != null)
            {
                return Ok(producto);
            }
            return BadRequest();
        }

        [HttpDelete]
        [Route("[Action]/{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_productosService.Delete(id));
        }
    }
}
