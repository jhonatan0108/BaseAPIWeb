using EcommerceAPI.Comunes.Classes.Contracts.Ecommerce;
using EcommerceAPI.Infraestructura.Database.Entities;

namespace EcommerceAPI.Dominio.Services.Ecommerce.Clientes
{
    public interface IClientesService
    {
        List<ClienteContract> ObtenerClientes();
        ClienteContract ObtenerCliente(int id);
        ClienteContract Crear(ClienteContract contract);
        ClienteContract Update(ClienteContract contract);
        bool Delete(int id);
        //ClienteContract Update(ClienteContract contract);
    }
}
