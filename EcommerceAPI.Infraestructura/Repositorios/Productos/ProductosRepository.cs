using EcommerceAPI.Infraestructura.Database.Context;
using EcommerceAPI.Infraestructura.Database.Entities;

namespace EcommerceAPI.Infraestructura.Repositorios.Productos
{
    public class ProductosRepository : IProductosRepository
    {
        private readonly EcommerceContext _context;
        public ProductosRepository(EcommerceContext context) {
            _context = context;
        }

        public ProductoEntity CrearProducto(ProductoEntity entidad)
        {
            _context.Productos.Add(entidad);
            _context.SaveChanges();
            return entidad;
        }

        public void DeleteProducto(ProductoEntity entidad)
        {
            _context.Productos.Remove(entidad);
            _context.SaveChanges();
        }

        public List<ProductoEntity> ObtenerProducto()
        {
            return _context.Productos.ToList();
        }

        public ProductoEntity ObtenerProducto(int id)
        {
            return _context.Productos.Find(id);
        }

        public ProductoEntity UpdateProducto(ProductoEntity entidad)
        {
            _context.Productos.Update(entidad);
            _context.SaveChanges();
            return entidad;
        }
    }
}
