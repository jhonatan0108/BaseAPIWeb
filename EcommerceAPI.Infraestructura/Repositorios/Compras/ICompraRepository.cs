using EcommerceAPI.Infraestructura.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceAPI.Infraestructura.Repositorios.Compras
{
    public interface ICompraRepository
    {
        List<CompraEntity> ObtenerCompras();
        CompraEntity ObtenerCompra(int id_compra);
        CompraEntity Crear(CompraEntity entidad);
        CompraEntity Update(CompraEntity entidad);
        void Delete(CompraEntity entidad);
    }
}
