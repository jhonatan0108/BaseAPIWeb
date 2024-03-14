using EcommerceAPI.Infraestructura.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceAPI.Infraestructura.Repositorios.Clientes
{
    public interface IClientesRepository
    {
        List<ClienteEntity> ObtenerClientes();

        ClienteEntity ObtenerCliente(int id);

        ClienteEntity Crear(ClienteEntity entidad);

        ClienteEntity Update(ClienteEntity entidad);

        void Delete(ClienteEntity entidad);
        ClienteEntity ObtenerCliente(object consecutivo);
        
     }
}
