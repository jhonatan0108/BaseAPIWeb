using AutoMapper;
using EcommerceAPI.Comunes.Classes.Contracts.Ecommerce;
using EcommerceAPI.Dominio.Services.Encripcion;
using EcommerceAPI.Dominio.Services.Jwt;
using EcommerceAPI.Infraestructura.Database.Entities;
using EcommerceAPI.Infraestructura.Repositorios.Clientes;
using Org.BouncyCastle.Crypto.Generators;

namespace EcommerceAPI.Dominio.Services.Ecommerce.Clientes
{
    public class ClientesService : IClientesService
    {
        private readonly IClientesRepository _repository;//se comunica con esta interfaz pero esta clase no sabe cuAL ES LA IMPLEMENTACION NI EL CONTEXTO
        private readonly IMapper _mapper;
        private readonly ICryptoService _cryptoService;
        private readonly IJWTService _jwtService;

        public ClientesService(
            IClientesRepository clientesRepository, 
            IMapper mapper, 
            ICryptoService cryptoService,
            IJWTService jwtService
            )
        {
            _repository = clientesRepository;
            _mapper = mapper;
            _cryptoService = cryptoService;
            _jwtService = jwtService;
        }
        public ClienteContract Create(ClienteContract contract)
        {
            ClienteEntity entity = _mapper.Map<ClienteEntity>(contract);//convierto el dto a la entidad
            string contrEncrypto = _cryptoService.Encriptar(entity.contrasena);//
            entity.contrasena = contrEncrypto;
            
            entity = _repository.Create(entity);//creo la entidad y guardo en entity
            ClienteContract response = _mapper.Map<ClienteContract>(entity);//transformo la entidad a dto
            return response;//devuelvo el dto
        }

        public bool Delete(int id)
        {
            ClienteEntity cliente = _repository.GetById(id);
            if (cliente!=null)
            {
                _repository.Delete(cliente);
                return true;
            }
            return false;
        }

        public List<ClienteContract> GetAll()
        {  
            string token = _jwtService.GenerarToken();
            List<ClienteEntity> entities = _repository.GetAll();
            List<ClienteContract> contract=_mapper.Map<List<ClienteContract>>(entities);
            return contract;
            //return _mapper.Map<List<ClienteContract>>(_repository.GetAll());
        }

        public ClienteContract GetById(int id)
        {
            ClienteEntity entity = _repository.GetById(id);
            ClienteContract contract = _mapper.Map<ClienteContract>(entity);
            return contract;
            //return _mapper.Map<ClienteContract>(_repository.GetById(id));
        }

        public ClienteContract Update(ClienteContract contract)
        {
            ClienteEntity entity = _repository.GetById(contract.id_cliente);
            string passEcypt = _cryptoService.Encriptar(contract.contrasena);
            if (entity!=null)
            {
                ClienteEntity entityActualizado = _mapper.Map<ClienteEntity>(contract);//mapeamos a entity los datos nuevos
                entityActualizado.contrasena = passEcypt;
               return _mapper.Map<ClienteContract>(_repository.Update(entityActualizado));//devolvemos los datos nuevos en un contract
            }
            return null; 
        }
    }
}
