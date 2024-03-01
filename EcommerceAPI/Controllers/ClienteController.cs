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
        public IActionResult Get()
        {
            return Ok(_clienteService.ObtenerClientes());

        }
    }
}
