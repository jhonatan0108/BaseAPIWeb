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
        private readonly IClientesService _clientesService;
        public ClienteController(IClientesService clientesService)
        {
            _clientesService = clientesService;
        }

        [HttpGet]
        //[Route("[Action]")]
        [Route("ClientesMostrarTodos")]
        public IActionResult GetAll()
        {
            List<ClienteContract> lista = _clientesService.ObtenerClientes();
            return Ok(lista);
        }

        [HttpGet]
        //[Route("[Action]/{id}")]
        [Route("ClienteMostrarporID")]
        public IActionResult GetbyId(int id)
        {
            //como se hacen cvalidaciones en el servicio, no se hace de esta forma
            //ClienteContract cliente = _clientesService.ObtenerCliente(id);
            //if(cliente != null)
            //{
            //    return Ok(cliente);
            //}
            //return BadRequest();

            return Ok(_clientesService.ObtenerCliente(id));
        }

        [HttpPost]
        //[Route("[Action]")]
        [Route("ClienteCrear")]
        public IActionResult Crear(ClienteContract contract)
        {
            ClienteContract cliente = _clientesService.Crear(contract);
            if (cliente == null)
            {
                return BadRequest();
            }
            return Ok(cliente);
            //Sin validacion
            //return Ok(_clientesService.Crear(contract));
        }

        [HttpPut]
        [Route("ClienteActualizar")]
        public IActionResult Update(ClienteContract contract)
        {
            ClienteContract cliente = _clientesService.Update(contract);
            if (cliente == null)
            {
                return BadRequest();
            }
            return Ok(cliente);
        }

        [HttpDelete]
        //[Route("[Action]/{id}")]
        [Route("ClienteEliminar")]
        public IActionResult Delete(int id)
        {
            //_clientesService.Delete(id);
            //return Ok();
            return Ok(_clientesService.Delete(id)); //Este fue el inicial
        }
    }
}
