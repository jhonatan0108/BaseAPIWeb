using EcommerceAPI.Infraestructura.Database.Context;
using EcommerceAPI.Infraestructura.Database.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceAPI.Infraestructura.Repositorios.Producto
{
    public class ProductoRepository : IProductoRepository
    {
        private readonly EcommerceContext _context;
        public ProductoRepository(EcommerceContext context)
        {
            _context = context;
        }

        public ProductoEntity Crear(ProductoEntity entidad)
        {
            _context.Producto.Add(entidad);
            _context.SaveChanges();
            return entidad;
        }

        public void Delete(ProductoEntity entidad)
        {
            _context.Producto.Remove(entidad);
            _context.SaveChanges();
        }


        public List<ProductoEntity> ObtenerProductos()
        {
            return _context.Producto.ToList();


        }
        public ProductoEntity ObtenerProductos(int id)
        {
            return _context.Producto.Find(id);
        }

        public ProductoEntity ObtenerProductos(object id)
        {
            throw new NotImplementedException();
        }

        public ProductoEntity Update(ProductoEntity entidad)
        {
            _context.Producto.Update(entidad);
            _context.SaveChanges();
            return entidad;

        }

        
    } 
}
