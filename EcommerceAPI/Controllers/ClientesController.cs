using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EcommerceAPI.Infraestructura.Database;
using EcommerceAPI.Infraestructura.Database.Entities;

namespace EcommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly Context _context;

        public ClientesController(Context context)
        {
            _context = context;
        }

        // GET: api/Cliente
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClienteEntity>>> ObtenerClientes()
        {
          if (_context.ClienteEntity == null)
          {
              return NotFound();
          }
            return await _context.ClienteEntity.ToListAsync();
        }

        // GET: api/Cliente/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ClienteEntity>> ObtenerPorId(int id)
        {
          if (_context.ClienteEntity == null)
          {
              return NotFound();
          }
            var clienteEntity = await _context.ClienteEntity.FindAsync(id);

            if (clienteEntity == null)
            {
                return NotFound();
            }

            return clienteEntity;
        }

        // PUT: api/Cliente/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, ClienteEntity clienteEntity)
        {
            if (id != clienteEntity.cedula)
            {
                return BadRequest();
            }

            _context.Entry(clienteEntity).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClienteEntityExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Cliente
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ClienteEntity>> Crear(ClienteEntity clienteEntity)
        {
          if (_context.ClienteEntity == null)
          {
              return Problem("Entity set 'Context.ClienteEntity'  is null.");
          }
            _context.ClienteEntity.Add(clienteEntity);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetClienteEntity", new { id = clienteEntity.cedula }, clienteEntity);
        }

        // DELETE: api/Cliente/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (_context.ClienteEntity == null)
            {
                return NotFound();
            }
            var clienteEntity = await _context.ClienteEntity.FindAsync(id);
            if (clienteEntity == null)
            {
                return NotFound();
            }

            _context.ClienteEntity.Remove(clienteEntity);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ClienteEntityExists(int id)
        {
            return (_context.ClienteEntity?.Any(e => e.cedula == id)).GetValueOrDefault();
        }
    }
}
