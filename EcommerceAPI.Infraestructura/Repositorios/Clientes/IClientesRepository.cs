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
        ClienteEntity Create(ClienteEntity entidad);
        ClienteEntity Update(ClienteEntity entidad);
        List<ClienteEntity> GetAll();
        void Delete(ClienteEntity entidad);
        ClienteEntity GetById(int id);


    }
}
