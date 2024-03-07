using EcommerceAPI.Comunes.Classes.Contracts.Ecommerce;
using EcommerceAPI.Dominio.Services.Ecommerce.Clientes;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controllers
{
    [Route("api/Clientes")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClientesService _clientesService;

        public ClienteController(IClientesService clientesService)
        {
            _clientesService = clientesService;
        }

        [HttpGet]
        [Route("[Action]")]
        public IActionResult Index()
        {
            return Ok(_clientesService.ObtenerClientes());
        }

        [HttpGet]
        [Route("[Action]/{id}")]
        public IActionResult GetbyId(Int64 id)
        {
            ClienteContract cliente = _clientesService.ObtenerCliente((Int64) id);
            if (cliente != null)
                return Ok(cliente);

            return BadRequest();
        }

        [HttpPost]
        [Route("[Action]")]
        public IActionResult Crear(ClienteContract contract)
        {
            ClienteContract cliente = _clientesService.Crear(contract);
            if (cliente == null)
            {
                return BadRequest();

            }

            return Ok(cliente);
        }

        [HttpPut]
        [Route("[Action]")]
        public IActionResult Update(ClienteContract contract)
        {
            ClienteContract cliente = _clientesService.Update(contract);
            if (cliente == null)
            {
                return BadRequest();

            }
            return Ok(cliente);
        }

        [HttpGet]
        [Route("[Action]/{id}")]
        public IActionResult Delete(Int64 id)
        {
           return Ok(_clientesService.Delete(id));

        }

    }
}
