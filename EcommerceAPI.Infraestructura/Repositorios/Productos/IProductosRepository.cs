

using EcommerceAPI.Infraestructura.Database.Entities;

namespace EcommerceAPI.Infraestructura.Repositorios.Productos
{
    public interface IProductosRepository
    {
        List<ProductoEntity> ObtenerProductos();
        ProductoEntity ObtenerProducto(string id);
        ProductoEntity Crear(ProductoEntity entidad);
        ProductoEntity Update(ProductoEntity entidad);
        void Delete(ProductoEntity entidad);
    }
}
