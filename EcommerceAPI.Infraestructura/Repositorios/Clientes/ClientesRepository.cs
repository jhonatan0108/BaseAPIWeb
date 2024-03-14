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
    public class ClientesRepository : IClientesRepository
    {

     private readonly EcommerceContext _context;

        public  ClientesRepository(EcommerceContext context)
        {
            _context = context;
        }

        public ClienteEntity Crear(ClienteEntity entidad)
        {
            _context.Clientes.Add(entidad);
            _context.SaveChanges();
            return entidad;
        }

        public void Delete(ClienteEntity entidad)
        {
            
            _context.Clientes.Remove(entidad);
            _context.SaveChanges();
        }

        public ClienteEntity ObtenerCliente(int id)
        {
            return _context.Clientes.Find(id);
            //return _context.Clientes.FirstOrDefault(x=>x.id_cliente==id);  Los id deben ser string
        }

        public ClienteEntity ObtenerCliente(object consecutivo)
        {
            throw new NotImplementedException();
        }

        public List<ClienteEntity> ObtenerClientes()
        {
            return _context.Clientes.ToList();
        }

        public ClienteEntity Upadte(ClienteEntity entidad)
        {
            throw new NotImplementedException();
        }

        public ClienteEntity Update(ClienteEntity entidad)
        {
            _context.Clientes.Update(entidad);
            _context.SaveChanges();
            return entidad;
        }
    }
}
