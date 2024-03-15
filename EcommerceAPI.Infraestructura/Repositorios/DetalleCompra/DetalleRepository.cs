using EcommerceAPI.Infraestructura.Database.Context;
using EcommerceAPI.Infraestructura.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceAPI.Infraestructura.Repositorios.DetalleCompra
{
    public class DetalleRepository : IDetalleRepository
    {
        private readonly EcommerceContext _context;
        public DetalleRepository(EcommerceContext context) { 
        _context = context;
        }
        public DetalleEntity Crear(DetalleEntity entidad)
        {
            _context.Add(entidad);
            _context.SaveChanges();
            return entidad;
        }

        public void Delete(DetalleEntity entidad)
        {
            _context.detalleCompra.Remove(entidad);
            _context.SaveChanges();
            
        }

        public DetalleEntity ObtenerDetalleCompra(int id_detallecompra)
        {
            return _context.detalleCompra.Find(id_detallecompra);
        }

        public List<DetalleEntity> ObtenerDetalleCompras()
        {
            return _context.detalleCompra.ToList();
        }

        public DetalleEntity Update(DetalleEntity entidad)
        {
           _context.detalleCompra.Update(entidad);
            _context.SaveChanges();
            return entidad;
        }
    }
}
