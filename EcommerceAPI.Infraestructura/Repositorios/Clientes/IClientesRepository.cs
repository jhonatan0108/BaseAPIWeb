﻿using EcommerceAPI.Infraestructura.Database.Entities;

namespace EcommerceAPI.Infraestructura.Repositorios.Clientes
{
    public interface IClientesRepository
    {
        List<ClienteEntity> ObtenerClientes();
        ClienteEntity ObtenerCliente(Int64 id);
        ClienteEntity Crear(ClienteEntity entidad);
        ClienteEntity Update(ClienteEntity entidad);
        void Delete(ClienteEntity entidad);
    }
}
