using EcommerceAPI.Infraestructura.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceAPI.Infraestructura.Repositorios.DetalleCompras
{
    public interface IDetalleComprasRepository
    {
        DetalleCompraEntity Create(DetalleCompraEntity entidad);
        DetalleCompraEntity Update(DetalleCompraEntity entidad);
        List<DetalleCompraEntity> GetAll();
        void Delete(DetalleCompraEntity entidad);
        DetalleCompraEntity GetById(int id);
    }
}
