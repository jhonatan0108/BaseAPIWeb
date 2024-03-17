using EcommerceAPI.Infraestructura.Database.Entities;
using EcommerceAPI.Comunes.Classes.Contracts.Ecommerce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceAPI.Dominio.Services.Ecommerce.Compras
{
    public interface ICompraService
    {
        async Task<CompraContract> CrearCompra(CompraContract compra);
        CompraContract BuscarCompra(int idCompra);
        List<CompraContract> ObtenerCompra();
        async Task<CompraContract> ActualizarCompra(CompraContract compra);
        bool BorrarCompra(int idCompra);  // xq no por ID
    }
}
