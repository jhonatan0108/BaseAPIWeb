using EcommerceAPI.Infraestructura.Database.Context;
using EcommerceAPI.Infraestructura.Database.Entities;
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
            _context.SaveChanges();
            return entidad;
        }

        public void Delete(ClienteEntity entidad)
        {
            _context.Remove(entidad);
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
