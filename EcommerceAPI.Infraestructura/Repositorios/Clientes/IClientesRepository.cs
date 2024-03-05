

using EcommerceAPI.Infraestructura.Database.Entities;

namespace EcommerceAPI.Infraestructura.Repositorios.Clientes
{
    public interface IClientesRepository
    {
        List<ClienteEntity> ObtenerClientes();
        ClienteEntity ObtenerClientes(int id);
        ClienteEntity Crear(ClienteEntity entidad);
        ClienteEntity Update(ClienteEntity entidad);
        void Delete(ClienteEntity entidad);
        ClienteEntity ObtenerClientes(object consecutivo);
    }
}
