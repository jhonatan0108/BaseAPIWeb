using EcommerceAPI.Infraestructura.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceAPI.Infraestructura.Repositorios.DetalleCompra
{
    public interface IDetalleCompraRepository
    {
        List<DetalleCompraEntity> ObtenerDetalleCompra();
        DetalleCompraEntity ObtenerDetalleCompra(int id);
        DetalleCompraEntity Crear(DetalleCompraEntity entidad);
        void Delete(DetalleCompraEntity entidad);
        void Update(DetalleCompraEntity entidad);
        DetalleCompraEntity ObtenerDetalleCompra(object id);
    }
}
