using EcommerceAPI.Infraestructura.Database.Entities;

namespace EcommerceAPI.Infraestructura.Repositorios.Productos
{
    public interface IProductosRepository
    {
        List<ProductoEntity> ObtenerProducto();
        ProductoEntity ObtenerProducto(int id);
        ProductoEntity CrearProducto(ProductoEntity entidad);
        ProductoEntity UpdateProducto(ProductoEntity entidad);
        void DeleteProducto(ProductoEntity entidad);
    }
}
