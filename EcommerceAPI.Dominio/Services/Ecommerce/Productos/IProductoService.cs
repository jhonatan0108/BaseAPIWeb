using EcommerceAPI.Comunes.Clases.Contracts.Ecommerce;
using EcommerceAPI.Comunes.Classes.Contracts.Ecommerce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceAPI.Dominio.Services.Ecommerce.Productos
{
    public interface IProductoService
    {
        List<ProductoContract> ObtenerProductos();
        ProductoContract ObtenerProducto(int id_producto);
        ProductoContract Crear(ProductoContract contract);
        ProductoContract Update(ProductoContract contract);
        bool Delete(int id_producto);
    }
}
