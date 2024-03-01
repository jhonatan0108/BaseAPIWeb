using AutoMapper;
using EcommerceAPI.Comunes.Classes.Contracts.Ecommerce;
using EcommerceAPI.Dominio.Services.Encripcion;
using EcommerceAPI.Infraestructura.Database.Entities;
using EcommerceAPI.Infraestructura.Repositorios.Clientes;
using System.Net.Http.Headers;

namespace EcommerceAPI.Dominio.Services.Ecommerce.Clientes
{
    public class ClientesService : IClientesService
    {
        private readonly IClientesRepository _repository;
        private readonly IMapper _mapper;
        private readonly ICryptoService _cryptoService;

        public ClientesService(
            IClientesRepository clientesRepository,
            IMapper mapper,
            ICryptoService cryptoService
            )
        {
            _repository = clientesRepository;
            _mapper = mapper;
            _cryptoService = cryptoService; 
        }
        public ClienteContract Crear(ClienteContract contract)
        {
            ClienteEntity entity = _mapper.Map<ClienteEntity>( contract );
            string contrEncript = _cryptoService.Encript( entity.contrasena);
            entity.contrasena = contrEncript;
            ClienteEntity entityResultado = _repository.Crear(entity);

            ClienteContract response = _mapper.Map<ClienteContract>(entityResultado);
            return response;
        }

        public bool Delete(int id)
        {
            ClienteEntity cliente = _repository.ObtenerCliente(id);
            if(cliente != null ) { 
                _repository.Delete(cliente);
                return true;
            }
            return false;
        }

        public bool Delete(ClienteEntity contract)
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

        public ClienteContract Update(ClienteContract contract)
        {
            ClienteEntity entidad = _repository.ObtenerCliente(contract.id_cliente);
            string passEncript = _cryptoService.Encript(contract.contrasena);
            if(entidad != null)
            {
                ClienteEntity entidadActualizar = _mapper.Map<ClienteEntity>( contract );
               entidadActualizar.contrasena = passEncript;
                return _mapper.Map<ClienteContract>(_repository.Update(entidadActualizar));
            }
            return null;
        }

        //public ClienteContract Update(ClienteContract contract)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
