using EcommerceAPI.Comunes.Classes.Contracts.Ecommerce;
using EcommerceAPI.Dominio.Services.Ecommerce.Productos;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controllers
{
    [Route("api/Productos")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly IProductosService _productosService;

        public ProductoController(IProductosService productosService)
        {
            _productosService = productosService;
        }

        [HttpGet]
        [Route("[Action]")]
        public IActionResult Index()
        {
            return Ok(_productosService.ObtenerProductos());
        }

        [HttpGet]
        [Route("[Action]/{id}")]
        public IActionResult GetbyId(string id)
        {
            ProductoContract producto = _productosService.ObtenerProducto(id);
            if (producto != null)
                return Ok(producto);
            else
            {
                //Console.WriteLine("Producto no existe");
                return BadRequest();
            }

        }

        [HttpPost]
        [Route("[Action]")]
        public IActionResult Crear(ProductoContract contract)
        {
            ProductoContract producto = _productosService.Crear(contract);
            if (producto == null)
            {
                return BadRequest();

            }
            return Ok(producto);
        }

        [HttpPut]
        [Route("[Action]")]
        public IActionResult Update(ProductoContract contract)
        {
            ProductoContract producto = _productosService.Update(contract);
            if (producto == null)
            {
                return BadRequest();

            }
            return Ok(producto);
        }

        [HttpGet]
        [Route("[Action]/{id}")]
        public IActionResult Delete(string id)
        {
            return Ok(_productosService.Delete(id));

        }
    }
}
