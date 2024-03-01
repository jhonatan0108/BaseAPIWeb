using AutoMapper;
using EcommerceAPI.Comunes.Classes.Contracts.Ecommerce;
using EcommerceAPI.Dominio.Services.Encripcion;
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
            ICryptoService cryptoService)
        {
            _repository = clientesRepository;
            _mapper = mapper;
            _cryptoService = cryptoService;
        }

        public ClienteContract Crear(ClienteContract contract)
        {
            ClienteEntity entity = _mapper.Map<ClienteEntity>(contract);
            
            string contrEncript = _cryptoService.Encript(entity.contrasena_cliente);
            entity.contrasena_cliente = contrEncript;

            ClienteEntity entityResultado = _repository.Crear(entity);

            ClienteContract response = _mapper.Map<ClienteContract>(entityResultado);
            return response;
        }

        public bool Delete(Int64 id)
        {
            ClienteEntity cliente = _repository.ObtenerCliente(id);
            if (cliente != null)
            {
                _repository.Delete(cliente);
                return true;
            }
            return false;
        }

        public ClienteContract ObtenerCliente(Int64 id)
        {
                    
            return _mapper.Map<ClienteContract>(_repository.ObtenerCliente((Int64)id));

        }

        public List<ClienteContract> ObtenerClientes()
        {
            return _mapper.Map<List<ClienteContract>>(_repository.ObtenerClientes());
        }

        public ClienteContract Update(ClienteContract contract)
        {
            ClienteEntity entidad = _repository.ObtenerCliente(contract.id_cliente);

            string contrEncript = _cryptoService.Encript(contract.contrasena);

            if (entidad != null)
            {
                ClienteEntity entidadActualizar = _mapper.Map<ClienteEntity>(contract);

                if (entidad.contrasena_cliente != contrEncript)
                {
                    entidadActualizar.contrasena_cliente = contrEncript;
                }
                else
                {
                    entidadActualizar.contrasena_cliente = entidad.contrasena_cliente;
                }


                return _mapper.Map<ClienteContract>(_repository.Update(entidadActualizar));    
            }
            return null;

        }
    }
}
