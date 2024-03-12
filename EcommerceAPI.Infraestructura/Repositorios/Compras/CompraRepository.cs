using EcommerceAPI.Infraestructura.Database.Context;
using EcommerceAPI.Infraestructura.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceAPI.Infraestructura.Repositorios.Compras
{
    public class CompraRepository : ICompraRepository
    {
        private readonly EcommerceContext _context;
        public CompraRepository(EcommerceContext context) { 
        
        _context = context;
        
        }
        public CompraEntity Crear(CompraEntity entidad)
        {
            _context.Add(entidad);
            _context.SaveChanges();
            return entidad;
        }

        public void Delete(CompraEntity entidad)
        {
           _context.Compras.Remove(entidad);
           _context.SaveChanges();

        }

        public CompraEntity ObtenerCompra(int id_compra)
        {
            return _context.Compras.Find(id_compra);
        }

        public List<CompraEntity> ObtenerCompras()
        {
            return _context.Compras.ToList();
        }

        public CompraEntity Update(CompraEntity entidad)
        {
            _context.Compras.Update(entidad);
            _context.SaveChanges();
            return entidad;
        }
    }
}
