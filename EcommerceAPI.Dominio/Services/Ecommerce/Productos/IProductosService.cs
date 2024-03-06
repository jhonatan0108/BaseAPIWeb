using EcommerceAPI.Comunes.Classes.Contracts.Ecommerce;

namespace EcommerceAPI.Dominio.Services.Ecommerce.Productos
{
    public interface IProductosService
    {
        List<ProductoContract> ObtenerProducto();
        ProductoContract ObtenerProducto(int id);
        ProductoContract Crear(ProductoContract contract);
        ProductoContract Update(ProductoContract contract);
        bool Delete(int id);
    }
}
