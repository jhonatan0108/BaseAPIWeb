using EcommerceAPI.Infraestructura.Database.Entities;
using EcommerceAPI.Comunes.Classes.Contracts.Ecommerce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EcommerceAPI.Dominio.Services.Ecommerce.Clientes
{
    public interface IClientesService
    {
        //debe tener los metodos para CRUD
        List<ClienteContract> ObtenerClientes();
        ClienteContract ObtenerPorId(decimal id);
        ClienteContract Crear(ClienteContract entidad);
        ClienteContract Update(ClienteContract entidad);
        bool Delete(decimal id);
    }
}
