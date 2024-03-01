using EcommerceAPI.Comunes.Classes.Contracts.Ecommerce;
using EcommerceAPI.Infraestructura.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceAPI.Dominio.Services.Ecommerce.Productos
{
    public interface IProductosService
    {
        //metodos para CRUD
        ProductoContract CrearProducto(ProductoContract producto);
        ProductoContract BuscarProducto(int id);
        List<ProductoContract> ObtenerProductos();
        ProductoContract ActualizarProducto(ProductoContract producto);
        bool BorrarProducto(int id);
    }
}
