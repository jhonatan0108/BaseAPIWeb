using EcommerceAPI.Comunes.Classes.Contracts.Ecommerce;
using EcommerceAPI.Dominio.Services.Ecommerce.Compras;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.EntityFrameworkCore.ChangeTracking;

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
        [Route("[Action]")]
        public IActionResult Get()
        {
            List<CompraContract> Cc= _compraService.GetAll();
            return Ok(Cc);
        }

        [HttpGet]
        [Route("[Action]/{id}")]
        public IActionResult Get(int id)
        {
            CompraContract Cc = _compraService.GetById(id);
            if (Cc!=null)
            {
                return Ok(Cc);
            }
            return BadRequest();
        }

        [HttpDelete]
        [Route("[Action]/{id}")]

        public IActionResult Delete(int id) 
        {
            CompraContract Contract = _compraService.GetById(id);
            if (Contract!=null)
            {
                _compraService.Delete(Contract.id_compra);
                return Ok();

            }
            return BadRequest("La compra no existe");
        }

        [HttpPut]
        [Route("[Action]")]
        public IActionResult Update(CompraContract Cc)
        {
            CompraContract CcNw = _compraService.Update(Cc);
            if (CcNw == null)
            {
                return BadRequest("El cliente no existe");


            }
            return Ok(CcNw);


        }

        [HttpPost]
        [Route("[Action]")]
        public IActionResult Create(CompraContract Cc)
        {
            CompraContract CcNw = _compraService.Create(Cc);
            if(CcNw == null)
            {
                return BadRequest();
            }
            return Ok(CcNw);
        }

    }
}
