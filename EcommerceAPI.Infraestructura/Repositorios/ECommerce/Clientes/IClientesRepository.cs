using EcommerceAPI.Infraestructura.Database.Entities;

namespace EcommerceAPI.Infraestructura.Repositorios.ECommerce.Clientes
{
    public interface IClientesRepository
    {
        Task<ClienteEntity> GetByEmail(string email);
        Task<ClienteEntity> LoginCliente(string email, string password);
    }
}
