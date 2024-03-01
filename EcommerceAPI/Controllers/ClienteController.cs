using EcommerceAPI.Comunes.Classes.Contracts.Ecommerce;
using EcommerceAPI.Dominio.Services.Ecommerce.Clientes;
using EcommerceAPI.Infraestructura.Database.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;

namespace EcommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClientesService _clientesService;

        public ClienteController(IClientesService clientesService)
        {
            _clientesService = clientesService;

        }

        [HttpGet]

        public IActionResult Get()
        {
            return Ok(_clientesService.ObtenerClientes());
        }

        [HttpGet("{id}")]

        public IActionResult Get(int id)
        {
            return Ok(_clientesService.ObtenerPorId(id));

        }
       
        [HttpPut("{Cliente}")]

        public IActionResult Put(ClienteContract contract)
        {
            return Ok(_clientesService.Update(contract));
        }

        [HttpPost]

        public IActionResult Crear(ClienteContract contract) {

            return Ok(_clientesService.Crear(contract));    
        
        }

        [HttpDelete("{id}")]

        public IActionResult Delete(int id)
        {
            return Ok(_clientesService.Delete(id));
        }
    }
}
