using EcommerceAPI.Infraestructura.Database.Context;
using EcommerceAPI.Infraestructura.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceAPI.Infraestructura.Repositorios.Productos
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
            _context.Add(entidad);
            _context.SaveChanges();
            return entidad;
        }

        public void Delete(ProductoEntity entidad)
        {
            _context.Productos.Remove(entidad);
            _context.SaveChanges();

        }

        public ProductoEntity ObtenerProducto(int id_producto)
        {
            return _context.Productos.Find(id_producto);
        }

        public List<ProductoEntity> ObtenerProductos()
        {
            return _context.Productos.ToList();
        }

        public ProductoEntity Update(ProductoEntity entidad)
        {
            _context.Productos.Update(entidad);
            _context.SaveChanges();
            return entidad;
        }
    }
}
