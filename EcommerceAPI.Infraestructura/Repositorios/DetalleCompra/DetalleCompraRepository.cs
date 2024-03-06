using EcommerceAPI.Infraestructura.Database.Context;
using EcommerceAPI.Infraestructura.Database.Entities;
using EcommerceAPI.Infraestructura.Repositorios.Compra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceAPI.Infraestructura.Repositorios.DetalleCompra
{
    internal class DetalleCompraRepository : IDetalleCompraRepository
    {
        private readonly EcommerceContext _context;
        public DetalleCompraRepository(EcommerceContext context)
        {
            _context = context;
        }
        public DetalleCompraEntity Crear(DetalleCompraEntity entidad)
        {
            _context.DetalleCompra.Add(entidad);
            _context.SaveChanges();
            return entidad;
        }

        public void Delete(DetalleCompraEntity entidad)
        {
            _context.DetalleCompra.Remove(entidad);
            _context.SaveChanges();
        }

        public List<DetalleCompraEntity> ObtenerDetalleCompra()
        {
            return _context.DetalleCompra.ToList();
        }

        public DetalleCompraEntity ObtenerDetalleCompra(int id)
        {
            return _context.DetalleCompra.Find(id);
        }

        public DetalleCompraEntity ObtenerDetalleCompra(object id)
        {
            throw new NotImplementedException();
        }

        public DetalleCompraEntity Update(DetalleCompraEntity entidad)
        {
            _context.DetalleCompra.Update(entidad);
            _context.SaveChanges();
            return entidad;
        }
        void IDetalleCompraRepository.Update(DetalleCompraEntity entidad)
        {
            throw new NotImplementedException();
        }
    }
}
