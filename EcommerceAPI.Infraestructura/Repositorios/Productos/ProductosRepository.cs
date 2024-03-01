
using EcommerceAPI.Infraestructura.Database.Context;
using EcommerceAPI.Infraestructura.Database.Entities;

namespace EcommerceAPI.Infraestructura.Repositorios.Productos
{
    public class ProductosRepository : IProductosRepository
    {
        private readonly EcommerceContext _context;
        public ProductosRepository(EcommerceContext context)
        {
            _context = context;
        }
        public ProductoEntity Crear(ProductoEntity entidad)
        {
            _context.Productos.Add(entidad);
            _context.SaveChanges();
            return entidad;
        }

        public void Delete(ProductoEntity entidad)
        {
            _context.Productos.Remove(entidad);
            _context.SaveChanges();
        }

        public ProductoEntity ObtenerProducto(string id)
        {
            return _context.Productos.Find(id);
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
