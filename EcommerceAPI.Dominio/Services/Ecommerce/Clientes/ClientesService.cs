

using AutoMapper;
using EcommerceAPI.Comunes.Classes.Contracts.Ecommerce;
using EcommerceAPI.Dominio.Services.Encriptacion;
using EcommerceAPI.Infraestructura.Database.Entities;
using EcommerceAPI.Infraestructura.Repositorios.Clientes;

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
            ClienteEntity entity = _mapper.Map<ClienteEntity>( contract);
            string contrEncript= _cryptoService.Encript(entity.Password);
            entity.Password = contrEncript;
            ClienteEntity entityResultado = _repository.Crear( entity );

            ClienteContract response = _mapper.Map<ClienteContract>( entityResultado );
            return response;
        }

        public bool Delete(int id)
        {
            ClienteEntity cliente = _repository.ObtenerClientes(id);
            if(cliente !=null)
            {
                _repository.Delete( cliente );
                return true;
            }
            return false;
        }

        public List<ClienteContract> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<ClienteContract> ObtenerClientes()
        {
            return _mapper.Map <List<ClienteContract>>(_repository.ObtenerClientes());
        }

        public ClienteContract ObtenerClientes(int id)
        {
            return _mapper.Map<ClienteContract>(_repository.ObtenerClientes(id));

        }

        public ClienteContract Update(ClienteContract contract)
        {
            ClienteEntity entidad = _repository.ObtenerClientes(contract.Consecutivo);
            string passEncript = _cryptoService.Encript(contract.password);
            if (entidad != null)
            {
                ClienteEntity entidadActualizar = _mapper.Map<ClienteEntity>(contract);
                if (entidad.Password != passEncript)
                    entidadActualizar.Password = passEncript;
                else
                    entidadActualizar.Password = entidad.Password;
                if (entidad.nombre != contract.nombre)
                    entidadActualizar.nombre = contract.nombre;
                else
                    entidadActualizar.nombre = entidad.nombre;

                return _mapper.Map<ClienteContract>(_repository.Update(entidadActualizar));
            }
            else
                return null;
        }
    }
}
