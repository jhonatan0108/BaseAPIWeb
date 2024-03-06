using AutoMapper;
using EcommerceAPI.Comunes.Classes.Contracts.Ecommerce;
using EcommerceAPI.Infraestructura.Database.Entities;
using EcommerceAPI.Infraestructura.Repositorios.Productos;

namespace EcommerceAPI.Dominio.Services.Ecommerce.Productos
{
    public class ProductosService : IProductosService
    {    
        private readonly IProductosRepository _repository;
        private readonly IMapper _mapper;

        public ProductosService(
            IProductosRepository ProductosRepository,
            IMapper mapper)
        {
            _repository = ProductosRepository;
            _mapper = mapper;
        }
        public ProductoContract Crear(ProductoContract contract)
        {
            ProductoEntity entity = _mapper.Map<ProductoEntity>(contract);
            
            ProductoEntity entityResultado = _repository.CrearProducto(entity);

            ProductoContract response = _mapper.Map<ProductoContract>(entityResultado);
            return response;
        }

        public bool Delete(int id)
        {
            ProductoEntity cliente = _repository.ObtenerProducto(id);
            if (cliente != null)
            {
                _repository.DeleteProducto(cliente);
                return true;
            }
            return false;
        }

        public List<ProductoContract> ObtenerProducto()
        {
            return _mapper.Map<List<ProductoContract>>(_repository.ObtenerProducto());
        }

        public ProductoContract ObtenerProducto(int id)
        {
            return _mapper.Map<ProductoContract>(_repository.ObtenerProducto(id));
        }

        public ProductoContract Update(ProductoContract contract)
        {
            ProductoEntity entidad = _repository.ObtenerProducto(contract.id_producto);
            if (entidad != null)
            {
                ProductoEntity entidadActualizar = _mapper.Map<ProductoEntity>(contract);
                return _mapper.Map<ProductoContract>(_repository.UpdateProducto(entidadActualizar));
            }
            return null;
        }
    }
}
