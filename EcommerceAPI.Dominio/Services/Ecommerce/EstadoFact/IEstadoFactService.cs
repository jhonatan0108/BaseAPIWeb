using EcommerceAPI.Comunes.Classes.Contracts.Ecommerce;
using EcommerceAPI.Infraestructura.Database.Entities;

namespace EcommerceAPI.Dominio.Services.Ecommerce.EstadoFact
{
    public interface IEstadoFactService
    {
        List<EstadoFactContract> ObtenerEstadoFacts();
        EstadoFactContract ObtenerEstadoFact(string id);
        EstadoFactContract Crear(EstadoFactContract contract);
        EstadoFactContract Update(EstadoFactContract contract);
        bool Delete(string id);

    }
}
