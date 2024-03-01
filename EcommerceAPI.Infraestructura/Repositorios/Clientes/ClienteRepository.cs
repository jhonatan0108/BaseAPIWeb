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
            throw new NotImplementedException();
        }

        public ClienteEntity ObtenerCliente(int id)
        {
            throw new NotImplementedException();
        }

        public List<ClienteEntity> ObtenerClientes()
        {
            throw new NotImplementedException();
        }

        public ClienteEntity Update(ClienteEntity entidad)
        {
            throw new NotImplementedException();
        }
    }
}
