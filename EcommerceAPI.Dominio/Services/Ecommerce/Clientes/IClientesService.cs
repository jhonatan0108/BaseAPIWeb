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
        List<ClienteContract> ObtenerClientes();

        ClienteContract ObtenerCliente(int id);

        ClienteContract Crear(ClienteContract entidad);

        //ClienteContract Upadte(ClienteContract entidad);

        bool Delete(int id);
        
        
        //List<ClienteContract> GetAll();
        
        
        ClienteContract Update(ClienteContract contract);
    }
}
