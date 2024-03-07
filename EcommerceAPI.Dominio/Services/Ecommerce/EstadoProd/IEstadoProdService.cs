using EcommerceAPI.Comunes.Classes.Contracts.Ecommerce;

namespace EcommerceAPI.Dominio.Services.Ecommerce.EstadoProd
{
    public interface IEstadoProdService
    {
        List<EstadoProdContract> ObtenerEstadoProd();
        EstadoProdContract ObtenerEstadoProd(string id);
        EstadoProdContract Crear(EstadoProdContract contract);
        EstadoProdContract Update(EstadoProdContract contract);
        bool Delete(string id);
    }
}
