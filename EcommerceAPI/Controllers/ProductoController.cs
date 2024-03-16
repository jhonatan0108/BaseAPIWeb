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
        public IActionResult Get()
        {
            List<ProductoContract> pc = _productoService.GetAll();

            return Ok(pc);

        }

        [HttpGet]
        [Route("[Action]/{id}")]
        public IActionResult GetById(int id)
        {
            ProductoContract pc = _productoService.GetById(id);
            if (pc != null)
            {
                return Ok(pc);
            }
            return BadRequest();
        }

        [HttpDelete]
        [Route("[Action]/{id}")]
        public IActionResult DeleteById(int id) 
        {
            ProductoContract pc = _productoService.GetById(id);
            if (pc != null) 
            {
                _productoService.Delete(id);
                return Ok();
            }
            return BadRequest("el producto no existe");
        }

        [HttpPost]
        [Route("[Action]")]
        public IActionResult Create(ProductoContract pc) {
            ProductoContract PNw = _productoService.Create(pc);
            if (PNw==null)
            {
                return BadRequest();
            }
            return Ok(PNw);
        }

        [HttpPut]
        [Route("[Action]")]
        public IActionResult Update(ProductoContract pc)
        {
            ProductoContract Pnw = _productoService.Update(pc);
            if (Pnw == null)
            {
                return BadRequest("El cliente no existe");


            }
            return Ok(Pnw);


        }
    }
}
