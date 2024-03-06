using AutoMapper;
using EcommerceAPI.Comunes.Classes.Contracts.Ecommerce;
using EcommerceAPI.Infraestructura.Database.Entities;
using EcommerceAPI.Infraestructura.Repositorios.Producto;

namespace EcommerceAPI.Dominio.Services.Ecommerce.Producto
{
    public class ProductoService : IProductoService
    {
        private readonly IProductoRepository _repository;
        private readonly IMapper _mapper;


        public ProductoService(
            IProductoRepository productoRepository,
            IMapper mapper
            )
        {
            _repository = productoRepository;
            _mapper = mapper;
        }
        public ProductoContract Crear(ProductoContract contract)
        {
            ProductoEntity entity = _mapper.Map<ProductoEntity>(contract);
            ProductoEntity entityResultado = _repository.Crear(entity);                       
            ProductoContract response = _mapper.Map<ProductoContract>(entityResultado);
                      
            return response;
        }

        public bool Delete(int id)
        {
            ProductoEntity producto = _repository.ObtenerProductos(id);

            if (producto != null)
            {
               
                _repository.Delete(producto);
                return true;
            }

            return false;
        }

        public List<ProductoContract> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<ProductoContract> ObtenerProductos()
        {
            return _mapper.Map<List<ProductoContract>>(_repository.ObtenerProductos());
        }

        public ProductoContract ObtenerProductos(int id)
        {
            return _mapper.Map<ProductoContract>(_repository.ObtenerProductos(id));
        }

        public ProductoContract Update(ProductoContract contract)
        {
            if (contract == null)
            {
                throw new ArgumentNullException(nameof(contract));
            }

            ProductoEntity entidad = _repository.ObtenerProductos(contract.Id);

            if (entidad == null)
            {
                return null;
            }

            try
            {
                _mapper.Map(contract, entidad);  
                _repository.Update(entidad);   
                return _mapper.Map<ProductoContract>(entidad);  
            }
            catch (Exception ex)
            {
                throw;  
            }
        }
    }
}
