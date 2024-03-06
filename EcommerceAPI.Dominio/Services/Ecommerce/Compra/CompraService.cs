using AutoMapper;
using EcommerceAPI.Comunes.Classes.Contracts.Ecommerce;
using EcommerceAPI.Dominio.Services.Encriptacion;
using EcommerceAPI.Infraestructura.Database.Entities;

using EcommerceAPI.Infraestructura.Repositorios.Compra;


namespace EcommerceAPI.Dominio.Services.Ecommerce.Compra
{
    public class CompraService : ICompraService
    {
        private readonly ICompraRepository _repository;
        private readonly IMapper _mapper;
 

        public CompraService(
            ICompraRepository compraRepository,
            IMapper mapper
            )
        {
            _repository = compraRepository;
            _mapper = mapper;
        }

        public CompraContract Crear(CompraContract contract)
        {
            CompraEntity entity = _mapper.Map<CompraEntity>(contract);
            CompraEntity entityResultado = _repository.Crear(entity);

            CompraContract response = _mapper.Map<CompraContract>(entityResultado);
            return response;
        }

        public bool Delete(int id)
        {
            CompraEntity compra = _repository.ObtenerCompra(id);
            if (compra != null)
            {
                _repository.Delete(compra);
                return true;
            }
            return false;
        }

        public List<CompraContract> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<CompraContract> ObtenerCompra()
        {
            return _mapper.Map<List<CompraContract>>(_repository.ObtenerCompra());
        }

        public CompraContract ObtenerCompra(int id)
        {
            return _mapper.Map<CompraContract>(_repository.ObtenerCompra(id));

        }

        public CompraContract Update(CompraContract contract)
        {
            if (contract == null)
            {
                throw new ArgumentNullException(nameof(contract));
            }

            CompraEntity entidad = _repository.ObtenerCompra(contract.Id);

            if (entidad == null)
            {
                return null;
            }

            try
            {
                _mapper.Map(contract, entidad);  
                _repository.Update(entidad);
                return _mapper.Map<CompraContract>(entidad);
            }
            catch (Exception ex)
            {
                
                throw;
            }
        }
    }
    
}
