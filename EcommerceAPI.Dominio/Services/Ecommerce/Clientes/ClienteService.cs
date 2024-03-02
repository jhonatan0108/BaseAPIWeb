using AutoMapper;
using EcommerceAPI.Comunes.Classes.Contracts.Ecommerce;
using EcommerceAPI.Infraestructura.Database.Entities;
using EcommerceAPI.Infraestructura.Repositorios.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceAPI.Dominio.Services.Ecommerce.Clientes
{
    public class ClienteService:IClienteService
    {
        private readonly IClienteRepository _repository;
        private readonly IMapper _mapper;

        public ClienteService(IClienteRepository clienteRepository,
        IMapper mapper) {
            _repository = clienteRepository;
            _mapper = mapper;   
     
        }

        public ClienteContract Crear(ClienteContract contract)
        {
            ClienteEntity entity = _mapper.Map<ClienteEntity>(contract);
            entity = _repository.Crear(entity);
            ClienteContract response = _mapper.Map<ClienteContract>(entity);
            return response;
        }

        public bool Delete(int id)
        {
            ClienteEntity cliente = _repository.ObtenerCliente(id);
            if (cliente != null)
            {
                _repository.Delete(cliente);
                return true;

            }
            return false;
        }

        public ClienteContract ObtenerCliente(int id)
        {

            return _mapper.Map<ClienteContract>(_repository.ObtenerCliente(id));
            //ClienteEntity entity = _repository.ObtenerCliente(id);
            //ClienteContract response = _mapper.Map<ClienteContract>(entity);
            //return response;    
        }

        public List<ClienteContract> ObtenerClientes()
        {

            return _mapper.Map<List<ClienteContract>>(_repository.ObtenerClientes());
        }

        public ClienteContract Update(ClienteContract contract)
        {
            ClienteEntity entidad = _repository.ObtenerCliente(contract.cedula);
            if (entidad != null) {

                ClienteEntity entidadActualizar = _mapper.Map<ClienteEntity>(contract);
                return _mapper.Map<ClienteContract>(entidadActualizar);
            }
            else
            {
                return null;

            }
        }

      
    }
}
