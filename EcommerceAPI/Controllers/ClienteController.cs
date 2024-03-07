using EcommerceAPI.Comunes.Classes.Contracts.Ecommerce;
using EcommerceAPI.Dominio.Services.Ecommerce.Clientes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteService _clienteService;
        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;

        }
        [HttpGet]
        [Route("[Action]")]
        public IActionResult GetAll()
        {
            return Ok(_clienteService.ObtenerClientes());

        }

        [HttpGet]
        [Route("[Action]/{cedula}")]
        public IActionResult GetbyId(int cedula)
        {
            ClienteContract cliente = _clienteService.ObtenerCliente(cedula);

          if (cliente !=  null) { 
                return Ok(cliente); 
            }else
            { return BadRequest(); }

        }

        [HttpPost]
        [Route("[Action]")]
        public IActionResult crearCliente(ClienteContract cliente)
        {
            ClienteContract _cliente = _clienteService.Crear(cliente);

            if (_cliente != null)
            {
                return Ok(_cliente);
            }
            else
            { return BadRequest(); }

        }

        [HttpPut]
        [Route("[Action]")]
        public IActionResult UpdateCliente(ClienteContract cliente)
        {
            ClienteContract _cliente = _clienteService.Update(cliente);

            if (_cliente != null)
            {
                return Ok(_cliente);
            }
            else
            { return BadRequest(); }

        }

        [HttpDelete]
        [Route("[Action]/{cedula}")]
        public IActionResult eliminarCliente(int cedula)
        {

            return Ok(_clienteService.Delete(cedula));

        }
    }
}
