using AutoMapper;
using EcommerceAPI.Comunes.Classes.Contracts.Ecommerce;
using EcommerceAPI.Comunes.Classes.Helpers.General;
using EcommerceAPI.Dominio.Services.Ecommerce.General;
using EcommerceAPI.Infraestructura.Database.Entities;
using EcommerceAPI.Infraestructura.Repositorios.ECommerce.Clientes;
using EcommerceAPI.Infraestructura.Repositorios.ECommerce.General;

namespace EcommerceAPI.Dominio.Services.Ecommerce.Clientes
{
    public class ClientesService : ICrudService<ClienteContract>
    {
        private readonly ICrudRepository<ClienteEntity> _crudRepository;
        private readonly IClientesRepository _clientesRepository;
        private readonly IMapper _mapper;
        private readonly ICifradoHelper _cifradoHelper;

        public ClientesService(
            ICrudRepository<ClienteEntity> crudRepository,
            IClientesRepository clientesRepository,
            IMapper mapper,
            ICifradoHelper cifradoHelper
            )
        {
            _crudRepository = crudRepository;
            _clientesRepository = clientesRepository;
            _mapper = mapper;
            _cifradoHelper = cifradoHelper;
        }

        /// <summary>
        /// Metodo para crear clientes en la base de datos
        /// </summary>
        /// <param name="entity">El objeto con los datos del cliente</param>
        /// <returns>El cliente creado y si no el cliente que ya existe</returns>
        public async Task<ClienteContract> CreateAsync(ClienteContract entity)
        {
            ClienteEntity cliente = await _clientesRepository.GetByEmail(entity.correo);
            if (cliente == null)
            {
                //Insertamos el nuevo cliente
                string contraEncript = _cifradoHelper.EncryptString(entity.contrasena);
                entity.contrasena = contraEncript;
                cliente = await _crudRepository.CreateAsync(_mapper.Map<ClienteEntity>(entity));
                return _mapper.Map<ClienteContract>(cliente);
            }
            else
            {
                return _mapper.Map<ClienteContract>(cliente);
            }
        }

        /// <summary>
        /// Metodo para eliminar un cliente de la base de datos
        /// </summary>
        /// <param name="entity">Objeto con datos del cliente</param>
        /// <returns></returns>
        public async Task DeleteAsync(int id)
        {
            ClienteEntity cliente = await _crudRepository.GetbyId(id);
            if (cliente != null)
            {
                //Eliminamos el cliente
                await _crudRepository.DeleteAsync(cliente);
            }
        }

        /// <summary>
        /// Metodo para obtener todos los clientes de nuestra BD
        /// </summary>
        /// <returns>Lista de clientes</returns>
        public async Task<List<ClienteContract>> GetAll()
        {
            List<ClienteEntity> clienteEntities = await _crudRepository.GetAll();
            return _mapper.Map<List<ClienteContract>>(clienteEntities);
        }

        /// <summary>
        /// Metodo para obtener un cliente por su ID
        /// </summary>
        /// <param name="id">parametro de consulta</param>
        /// <returns>Objeto de cliente</returns>
        public async Task<ClienteContract> GetbyId(int id)
        {
            ClienteEntity customer = await _crudRepository.GetbyId(id);
            if (customer != null)
            {
                return _mapper.Map<ClienteContract>(customer);
            }
            return _mapper.Map<ClienteContract>(customer);
        }

        /// <summary>
        /// Metodo para actualizar un cliente
        /// </summary>
        /// <param name="entity">objeto con datos del cliente</param>
        /// <returns>Cliente actualizado y si no vacio</returns>
        public async Task<ClienteContract> UpdateAsync(ClienteContract entity)
        {
            ClienteEntity cliente = await _crudRepository.GetbyId(entity.id_cliente);
            if (cliente != null)
            {
                cliente = await _crudRepository.UpdateAsync(_mapper.Map<ClienteEntity>(entity));
                return _mapper.Map<ClienteContract>(cliente);
            }
            else
            {
                return new ClienteContract();
            }
        }
    }
}
