
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
            IProductosRepository productosRepository,
            IMapper mapper)
        {
            _repository = productosRepository;
            _mapper = mapper;
        }
        public ProductoContract Crear(ProductoContract contract)
        {
            ProductoEntity entity = _mapper.Map<ProductoEntity>(contract);

            ProductoEntity entityResultado = _repository.Crear(entity);

            ProductoContract response = _mapper.Map<ProductoContract>(entityResultado);
            return response;
        }

        public bool Delete(string id)
        {
            ProductoEntity producto = _repository.ObtenerProducto(id);
            if (producto != null)
            {
                _repository.Delete(producto);
                return true;
            }
            return false;
        }

        public ProductoContract ObtenerProducto(string id)
        {
            return _mapper.Map<ProductoContract>(_repository.ObtenerProducto(id));

        }

        public List<ProductoContract> ObtenerProductos()
        {
            return _mapper.Map<List<ProductoContract>>(_repository.ObtenerProductos());
        }

        public ProductoContract Update(ProductoContract contract)
        {
            ProductoEntity entidad = _repository.ObtenerProducto(contract.cod_producto);

            if (entidad != null)
            {
                ProductoEntity entidadActualizar = _mapper.Map<ProductoEntity>(contract);
                return _mapper.Map<ProductoContract>(_repository.Update(entidadActualizar));
            }
            return null;
        }
    }
}
