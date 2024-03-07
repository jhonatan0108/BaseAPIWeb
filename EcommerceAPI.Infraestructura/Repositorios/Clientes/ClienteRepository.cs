using EcommerceAPI.Infraestructura.Database.Context;
using EcommerceAPI.Infraestructura.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceAPI.Infraestructura.Repositorios.Clientes
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly EcommerceContext _context;
        public ClienteRepository(EcommerceContext context)
        {
            _context = context;
        }

        public ClienteEntity Crear(ClienteEntity entidad)
        {
            _context.Add(entidad);
            _context.SaveChanges();
            return entidad;
        }


        public void Delete(ClienteEntity entidad)
        {
            _context.Clientes.Remove(entidad);
            _context.SaveChanges();
        }

        public ClienteEntity ObtenerCliente(int cedula)
        {
            return _context.Clientes.Find(cedula);
        }

        public List<ClienteEntity> ObtenerClientes()
        {
            return _context.Clientes.ToList();
        }

        public ClienteEntity Update(ClienteEntity entidad)
        {
            _context.Clientes.Update(entidad);
            _context.SaveChanges();
            return entidad;
        }
    }
}
