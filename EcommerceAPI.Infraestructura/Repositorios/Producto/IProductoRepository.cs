using EcommerceAPI.Infraestructura.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceAPI.Infraestructura.Repositorios.Producto
{
    public interface IProductoRepository
    {
        List<ProductoEntity> ObtenerProductos();
        ProductoEntity ObtenerProductos(int id);
        ProductoEntity Crear(ProductoEntity entidad);
        ProductoEntity Update(ProductoEntity entidad);
        void Delete(ProductoEntity entidad);
        ProductoEntity ObtenerProductos(object id);
    }
}
