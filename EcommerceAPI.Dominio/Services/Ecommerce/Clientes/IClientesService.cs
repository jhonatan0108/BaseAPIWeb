

using EcommerceAPI.Comunes.Classes.Contracts.Ecommerce;
using EcommerceAPI.Infraestructura.Database.Entities;

namespace EcommerceAPI.Dominio.Services.Ecommerce.Clientes
{
    // Se define el CRUD para que la capa de presentacion se pueda conectar.
    public interface IClientesService
    {
        List<ClienteContract> ObtenerClientes();
        ClienteContract ObtenerCliente(Int64 id);
        ClienteContract Crear(ClienteContract contract);
        ClienteContract Update(ClienteContract contract);
        bool Delete(Int64 id);
    }
}
