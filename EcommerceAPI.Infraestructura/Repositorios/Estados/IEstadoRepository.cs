using EcommerceAPI.Infraestructura.Database.Entities;

namespace EcommerceAPI.Infraestructura.Repositorios.Estados
{
    public interface IEstadoRepository
    {

        List<EstadoEntity> ObtenerEstados();
        EstadoEntity ObtenerEstados(int id);
        EstadoEntity Crear(EstadoEntity entidad);
        EstadoEntity Update(EstadoEntity entidad);
        void Delete(EstadoEntity entidad);
    }
}
