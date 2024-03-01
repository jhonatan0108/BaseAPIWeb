using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcommerceAPI.Comunes.Classes.Contracts.Ecommerce;
using EcommerceAPI.Infraestructura.Repositorios.Clientes;
using AutoMapper;
using EcommerceAPI.Infraestructura.Database.Entities;
using System.Security.Authentication;
using System.Diagnostics.Contracts;

namespace EcommerceAPI.Dominio.Services.Ecommerce.Clientes
{
    public class ClientesService : IClientesService
    {
        private readonly IClientesRepository _repository;
        private readonly IMapper _mapper;

        public ClientesService(
            IClientesRepository clientesRepository,
            IMapper mapper)
        {
            _repository = clientesRepository;
            _mapper = mapper;
        }

        public ClienteContract Crear(ClienteContract contract)
        {
            //Mapea El contrato con la entidad, que se encuentra en el repositorio
            
            ClienteEntity clienteExiste = _repository.ObtenerPorId(contract.cedula);
            if (clienteExiste ==null)
            {
                ClienteEntity entity = _mapper.Map<ClienteEntity>(contract);
                ClienteContract response = _mapper.Map<ClienteContract>(_repository.Crear(entity));
                return response;
            }
            else
            {
                return null;
            }
            
        }

        public bool Delete(decimal id)
        {
            ClienteEntity entidad = _repository.ObtenerPorId(id);
            if (entidad != null) {
                _repository.Delete(entidad);
                return true;
            }
            return false;
        }

        public List<ClienteContract> ObtenerClientes()
        {
            return _mapper.Map<List<ClienteContract>>(_repository.ObtenerClientes());
        }

        public ClienteContract ObtenerPorId(decimal id)
        {
            ClienteEntity entidad = _repository.ObtenerPorId(id);
            ClienteContract response = _mapper.Map<ClienteContract>(entidad);
            return response;
        }

        public ClienteContract Update(ClienteContract contract)
        {
            ClienteEntity entity = _repository.ObtenerPorId(contract.cedula);
            if (entity != null)
            {
                ClienteEntity entidadActualizar = _mapper.Map<ClienteEntity>(contract);
                return _mapper.Map<ClienteContract>(_repository.Update(entidadActualizar));
            }
            else{
                return null;
            }
        }
    }
}
