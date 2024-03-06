using EcommerceAPI.Comunes.Classes.Contracts.Ecommerce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceAPI.Dominio.Services.Ecommerce.Producto
{
    public interface IProductoService
    {
        List<ProductoContract> ObtenerProductos();

        
        ProductoContract ObtenerProductos(int id);

       
        ProductoContract Crear(ProductoContract contract);

        
        ProductoContract Update(ProductoContract contract);

        
        bool Delete(int id);

       
        List<ProductoContract> GetAll();
    }
}
