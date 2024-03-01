using EcommerceAPI.Comunes.Classes.Contracts.Ecommerce;
using EcommerceAPI.Infraestructura.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceAPI.Dominio.Services.Ecommerce.Clientes
{
    public interface IClientesService
    {
        ClienteContract Create(ClienteContract contract);
        ClienteContract Update(ClienteContract contract);
        List<ClienteContract> GetAll();
        bool Delete(int id);
        ClienteContract GetById(int id);

    }
}
