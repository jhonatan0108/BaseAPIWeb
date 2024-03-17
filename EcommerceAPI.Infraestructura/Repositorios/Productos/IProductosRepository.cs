using EcommerceAPI.Infraestructura.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceAPI.Infraestructura.Repositorios.Productos
{
    public interface IProductosRepository
    {
        //Listas Productos
        List<ProductoEntity> ObtenerProductos();

        //BuscarProducto
        ProductoEntity BuscarProducto(Int32 id);

        //Crear Producto
        ProductoEntity CrearProducto(ProductoEntity producto);
        
        //Actualizar Producto
        ProductoEntity ActualizarProducto (ProductoEntity producto);
        
        //Borrar Producto
        void BorrarProducto(ProductoEntity producto);
    }
}
