
using EcommerceAPI.Comunes.Classes.Contracts.Ecommerce;

namespace EcommerceAPI.Dominio.Services.Ecommerce.Productos
{
    public interface IProductosService
    {
        List<ProductoContract> ObtenerProductos();
        ProductoContract ObtenerProducto(string id);
        ProductoContract Crear(ProductoContract contract);
        ProductoContract Update(ProductoContract contract);
        bool Delete(string id);
    }
}
