using EcommerceAPI.Comunes.Clases.Contracts.Ecommerce;
using EcommerceAPI.Comunes.Classes.Contracts.Ecommerce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceAPI.Dominio.Services.Ecommerce.Compra
{
    public interface ICompraService
    {
        List<CompraContract> ObtenerCompras();
        CompraContract ObtenerCompra(int id_compra);
        CompraContract Crear(CompraContract contract);
        CompraContract Update(CompraContract contract);
        bool Delete(int id_compra);
    }
}
