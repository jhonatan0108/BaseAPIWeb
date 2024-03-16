using EcommerceAPI.Infraestructura.Database.Context;
using EcommerceAPI.Infraestructura.Database.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceAPI.Infraestructura.Repositorios.DetalleCompras
{
    public class DetalleComprasRepository : IDetalleComprasRepository
    {
        private readonly EcommerceContext _context;

        public DetalleComprasRepository(EcommerceContext context)
        {
            _context = context;
        }
        public DetalleCompraEntity Create(DetalleCompraEntity entidad)
        {
            _context.DetalleCompras.Add(entidad);
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

        public void Delete(DetalleCompraEntity entidad)
        {
            _context.Remove(entidad);
            _context.SaveChanges();
        }

        public List<DetalleCompraEntity> GetAll()
        {
           return  _context.DetalleCompras.ToList();
        }

        public DetalleCompraEntity GetById(int id)
        {
            return _context.DetalleCompras.Find(id);
        }

        public DetalleCompraEntity Update(DetalleCompraEntity entidad)
        {
            _context.DetalleCompras.Update(entidad);
            _context.SaveChanges();
            return entidad;
        }
    }
}
