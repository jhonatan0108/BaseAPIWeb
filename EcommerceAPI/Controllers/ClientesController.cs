using EcommerceAPI.Comunes.Classes.Contracts.Ecommerce;
using EcommerceAPI.Dominio.Services.Ecommerce.General;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace EcommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly ICrudService<ClienteContract> _service;
        public ClientesController(ICrudService<ClienteContract> service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _service.GetAll());
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _service.GetbyId(id));
        }

        [HttpPost]
        public async Task<IActionResult> Add(ClienteContract contract)
        {
            return Ok(await _service.CreateAsync(contract));
        }

        [HttpPut]
        public async Task<IActionResult> Update(ClienteContract contract)
        {
            return Ok(await _service.UpdateAsync(contract));
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.DeleteAsync(id);
            return Ok();
        }
    }
}
