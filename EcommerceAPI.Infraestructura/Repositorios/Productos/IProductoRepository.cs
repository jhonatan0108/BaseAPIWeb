using EcommerceAPI.Infraestructura.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceAPI.Infraestructura.Repositorios.Productos
{
    public interface IProductoRepository
    {
        List<ProductoEntity> ObtenerProductos();
        ProductoEntity ObtenerProducto(int id_producto);
        ProductoEntity Crear(ProductoEntity entidad);
        ProductoEntity Update(ProductoEntity entidad);
        void Delete(ProductoEntity entidad);
    }
}
