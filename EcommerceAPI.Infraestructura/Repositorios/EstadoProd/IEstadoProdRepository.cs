

using EcommerceAPI.Infraestructura.Database.Entities;

namespace EcommerceAPI.Infraestructura.Repositorios.EstadoProd
{
    public interface IEstadoProdRepository
    {
        List<EstadoProdEntity> ObtenerEstadoProd();
        EstadoProdEntity ObtenerEstadoProd(string id);
        EstadoProdEntity Crear(EstadoProdEntity entidad);
        EstadoProdEntity Update(EstadoProdEntity entidad);
        void Delete(EstadoProdEntity entidad);

    }
}
