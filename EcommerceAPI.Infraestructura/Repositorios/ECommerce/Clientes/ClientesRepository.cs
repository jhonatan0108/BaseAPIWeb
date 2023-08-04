using EcommerceAPI.Infraestructura.Database.Context;
using EcommerceAPI.Infraestructura.Database.Entities;
using EcommerceAPI.Infraestructura.Repositorios.ECommerce.General;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace EcommerceAPI.Infraestructura.Repositorios.ECommerce.Clientes
{
    public class ClientesRepository : IClientesRepository, ICrudRepository<ClienteEntity>
    {
        private readonly EcommerceContext _context;
        public ClientesRepository(EcommerceContext context)
        {
            _context = context;
        }

        public async Task<ClienteEntity> CreateAsync(ClienteEntity entity)
        {
            _context.Clientes.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(ClienteEntity entity)
        {
            _context.Clientes.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<List<ClienteEntity>> GetAll()
        {
            return await _context.Clientes.ToListAsync();
        }

        public async Task<ClienteEntity> GetByEmail(string email)
        {
            return await _context.Clientes
                 .FirstOrDefaultAsync(entidad => entidad.correo == email);
        }

        public async Task<ClienteEntity> GetbyId(int id)
        {
            return await _context.Clientes
                 .FirstOrDefaultAsync(entidad => entidad.id_cliente == id);
        }

        public async Task<ClienteEntity> LoginCliente(string email, string password)
        {
            return await _context.Clientes
                 .FirstOrDefaultAsync(entidad => entidad.correo == email && entidad.contrasena == password);
        }

        public async Task<ClienteEntity> UpdateAsync(ClienteEntity entity)
        {
            _context.Clientes.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
        //public async Task<ClienteEntity> Test(ClienteEntity entity)
        //{
        //    _context.Clientes.FromSqlRaw("CRUD_Estudiante @param1, @param2",
        //        new SqlParameter("@param1",1)).ToListAsync();
        //    await _context.SaveChangesAsync();
        //    return entity;
        //}
    }
}
