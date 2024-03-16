using EcommerceAPI.Comunes.Classes.Contracts.Ecommerce;
using EcommerceAPI.Dominio.Services.Ecommerce.Clientes;
using EcommerceAPI.Infraestructura.Database.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ClienteController : ControllerBase
    {
        private readonly IClientesService _clientesService;//desacoplamos la implementacion solo trayendo la interfaz
        public ClienteController(IClientesService clientesService)
        {
            _clientesService = clientesService;
        }
        [HttpGet]
        
        public IActionResult Get()
        {
            
            List<ClienteContract> lista = _clientesService.GetAll();
            return Ok(lista);
        }

        [HttpGet]
        [Route("[Action]/{id}")]
        public IActionResult GetbyId(int id)
        {
            ClienteContract cliente = _clientesService.GetById(id);
            if (cliente != null) 
            {
                return Ok(cliente);
            }
            return BadRequest();
        }

        [HttpDelete]
        [Route("[Action]/{id}")]
        public IActionResult DeleteById(int id) 
        {
            ClienteContract cliente = _clientesService.GetById(id);
            if (cliente != null) {
                _clientesService.Delete(id);
                return Ok();
            }
            return BadRequest("el cliente no existe");
            
        }

        [HttpPut]
        [Route("[Action]")]
        public IActionResult Update(ClienteContract cl) 
        {
            ClienteContract cliente = _clientesService.Update(cl);
            if (cliente==null)
            {
                return BadRequest("El cliente no existe");
               
               
            }
            return Ok(cliente);


        }

        [HttpPost]
        [Route("[Action]")]
        public IActionResult Create(ClienteContract cl) 
        {
           ClienteContract clNw = _clientesService.Create(cl);
            if (cl == null) {
                return BadRequest();
            }
            return Ok(clNw);
        }
    }
}





