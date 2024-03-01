using EcommerceAPI.Comunes.Classes.Contracts.Ecommerce;
using EcommerceAPI.Infraestructura.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceAPI.Dominio.Services.Ecommerce.Clientes
{
    public  interface IClienteService
    {
        List<ClienteContract> ObtenerClientes();
        ClienteContract ObtenerCliente(int id);
        ClienteContract Crear(ClienteContract contract);
        ClienteContract Update(ClienteContract contract);
        bool Delete(int id);
    }
}
