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

        ProductoEntity Create(ProductoEntity entidad);
        ProductoEntity Update(ProductoEntity entidad);
        List<ProductoEntity> GetAll();
        void Delete(ProductoEntity entidad);
        ProductoEntity GetById(int id);
    }
}
