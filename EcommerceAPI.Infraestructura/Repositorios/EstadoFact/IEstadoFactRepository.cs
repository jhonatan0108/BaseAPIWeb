
using EcommerceAPI.Infraestructura.Database.Entities;

namespace EcommerceAPI.Infraestructura.Repositorios.EstadoFact
{
    public interface IEstadoFactRepository
    {
        List<EstadoFactEntity> ObtenerEstadoFacts();
        EstadoFactEntity ObtenerEstadoFact(string id);
        EstadoFactEntity Crear(EstadoFactEntity entidad);
        EstadoFactEntity Update(EstadoFactEntity entidad);
        void Delete(EstadoFactEntity entidad);
    }
}
