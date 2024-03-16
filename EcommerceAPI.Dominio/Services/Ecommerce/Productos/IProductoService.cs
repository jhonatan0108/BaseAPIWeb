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
        ProductoContract Create(ProductoContract contract);
        ProductoContract Update(ProductoContract contract);
        List<ProductoContract> GetAll();
        bool Delete(int id);
        ProductoContract GetById(int id);
    }
}
