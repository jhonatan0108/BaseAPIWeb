using EcommerceAPI.Comunes.Classes.Contracts.Ecommerce;

namespace EcommerceAPI.Dominio.Services.Ecommerce.Estados
{
    public interface IEstadosService
    {
        List<EstadoContract> ObtenerEstado();
        EstadoContract ObtenerEstado(int id);
        EstadoContract Crear(EstadoContract contract);
        EstadoContract Update(EstadoContract contract);
        bool Delete(int id);
    }
}
