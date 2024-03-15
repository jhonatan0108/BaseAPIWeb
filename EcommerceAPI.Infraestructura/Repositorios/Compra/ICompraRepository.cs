

using EcommerceAPI.Infraestructura.Database.Entities;

namespace EcommerceAPI.Infraestructura.Repositorios.Compra
{
    public interface ICompraRepository
    {
        List<CompraEntity> ObtenerCompra();
        CompraEntity ObtenerCompra(int id);
        CompraEntity Crear(CompraEntity entidad);
        void Delete(CompraEntity entidad);
        CompraEntity Update(CompraEntity entidad);
        CompraEntity ObtenerCompra(object id);
  
    }
}
