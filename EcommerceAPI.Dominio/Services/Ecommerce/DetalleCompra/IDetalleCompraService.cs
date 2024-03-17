using EcommerceAPI.Comunes.Classes.Contracts.Ecommerce;
using EcommerceAPI.Infraestructura.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceAPI.Dominio.Services.Ecommerce.DetalleCompra
{
    public interface IDetalleCompraService
    {
        List<DetalleCompraContract> ObtenerDetalle();

        DetalleCompraContract CrearDetalle(DetalleCompraContract detalle);

         DetalleCompraContract BuscarDetalle(int idDetalle);

        DetalleCompraContract ActualizarDetalle(DetalleCompraContract detalle);

        bool BorrarDetalle(int detalle); 
    }
}
