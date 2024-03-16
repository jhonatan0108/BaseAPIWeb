using EcommerceAPI.Infraestructura.Database.Context;
using EcommerceAPI.Infraestructura.Database.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceAPI.Infraestructura.Repositorios.Clientes
{
    public class ClienteRepository : IClientesRepository
    {
        private readonly EcommerceContext _context;
        public ClienteRepository(EcommerceContext context) 
        {
            _context = context;
        }
        public ClienteEntity Create(ClienteEntity entidad)
        {
            _context.Clientes.Add(entidad);//usamos el contrexto y trabajamos sobre la tabla llamando los metodos de linQ
            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                // Manejar la excepción aquí
                Console.WriteLine(ex.Message);
            }
            return entidad;
        }

        public void Delete(ClienteEntity entidad)
        {
            _context.Clientes.Remove(entidad);
            _context.SaveChanges();
        }

        public List<ClienteEntity> GetAll()
        {
            return _context.Clientes.ToList();
        }

        public ClienteEntity GetById(int id)
        {
            return _context.Clientes.Find(id);
        }

        public ClienteEntity Update(ClienteEntity entidad)
        {
            _context.Clientes.Update(entidad);
            _context.SaveChanges();
            return entidad;
        }
    }
}
