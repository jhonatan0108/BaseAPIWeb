using EcommerceAPI.Comunes.Classes.Contracts.Ecommerce;
using EcommerceAPI.Dominio.Services.Ecommerce.Clientes;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClientesService _clientesService;

        public ClienteController (IClientesService clientesService)
        {
            _clientesService = clientesService;
        } 
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_clientesService.ObtenerClientes());
        }

        [HttpGet]
        [Route("[Action]/{id}")]
        public IActionResult GetbyId(int id)
        {
            ClienteContract cliente = _clientesService.ObtenerCliente(id);
            if (cliente != null)
            {
                return Ok(cliente);
            }
            return BadRequest();
        }

        [HttpGet]
        [Route("[Action]")]
        public IActionResult GetAll()
        {
            return Ok(_clientesService.ObtenerClientes());
        }

        [HttpPost]
        [Route("[Action]")]
        public IActionResult Crear(ClienteContract contract)
        {
            ClienteContract cliente = _clientesService.Crear(contract);
            if (cliente != null)
            {
                return Ok(cliente);
            }
            return BadRequest();
        }

        [HttpPost]
        [Route("ClienteUpdate")]
        public IActionResult Update(ClienteContract contract)
        {
            ClienteContract cliente = _clientesService.Update(contract);
            if (cliente != null)
            {
                return Ok(cliente);
            }
            return BadRequest();
        }

        [HttpDelete]
        [Route("[Action]/{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_clientesService.Delete(id));
        }
    }



}
