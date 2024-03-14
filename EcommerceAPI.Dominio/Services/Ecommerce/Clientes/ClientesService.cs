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
            ClienteEntity entity = _mapper.Map<ClienteEntity>(contract);
            entity = _repository.Crear(entity);
            ClienteContract response = _mapper.Map<ClienteContract>(entity);
            return response;

        }

    

        public bool Delete(int id)
        {
            ClienteEntity cliente = _repository.ObtenerCliente(id);
            if(cliente != null)
            {
                _repository.Delete(cliente);
                return true;
            }
            return false;

        }

        public List<ClienteContract> GetAll()
        {
            throw new NotImplementedException();
        }

        public ClienteContract ObtenerCliente(int id)
        {
            return _mapper.Map<ClienteContract>(_repository.ObtenerCliente(id));
        }

        public List<ClienteContract> ObtenerClientes()
        {
            return _mapper.Map<List<ClienteContract>>(_repository.ObtenerClientes());
        }

        //public clientecontract upadte(clientecontract entidad)
        //{
        //    throw new notimplementedexception();
        //}

        public ClienteContract Update(ClienteContract contract)
        {
            ClienteEntity entidad = _repository.ObtenerCliente(contract.id_cliente);
            if (entidad != null)
            {
                
                entidad = _mapper.Map<ClienteEntity>(contract);
                _repository.Update(entidad);
                return _mapper.Map<ClienteContract>(_repository.Update(entidad));
            }
            else
                return null;

        }

        //bool IClientesService.Delete(int id)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
