using EcommerceAPI.Infraestructura.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceAPI.Infraestructura.Repositorios.DetalleCompra
{
    public interface IDetalleRepository
    {
        List<DetalleEntity> ObtenerDetalleCompras();
        DetalleEntity ObtenerDetalleCompra(int id_detallecompra);
        DetalleEntity Crear(DetalleEntity entidad);
        DetalleEntity Update(DetalleEntity entidad);
        void Delete(DetalleEntity entidad);
    }
}
