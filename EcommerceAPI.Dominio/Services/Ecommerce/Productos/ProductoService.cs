using AutoMapper;
using EcommerceAPI.Comunes.Clases.Contracts.Ecommerce;
using EcommerceAPI.Infraestructura.Database.Entities;
using EcommerceAPI.Infraestructura.Repositorios.Productos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceAPI.Dominio.Services.Ecommerce.Productos
{
    public class ProductoService : IProductoService
    {
        private readonly IProductoRepository _productoRepository;
        private readonly IMapper _mapper;

        public ProductoService(IProductoRepository productoRepository, IMapper mapper)
        {
           _productoRepository = productoRepository;
            _mapper = mapper;
        }
        public ProductoContract Crear(ProductoContract contract)
        {
            ProductoEntity entity = _mapper.Map<ProductoEntity>(contract);
            entity = _productoRepository.Crear(entity);
            ProductoContract response = _mapper.Map<ProductoContract>(entity);
            return response;
        }

        public bool Delete(int id_producto)
        {
           ProductoEntity entity = _productoRepository.ObtenerProducto(id_producto);
            if (entity != null)
            {
                _productoRepository.Delete(entity);
                return true;
            }else { return false; }
        }

        public ProductoContract ObtenerProducto(int id_producto)
        {
            return _mapper.Map<ProductoContract>(_productoRepository.ObtenerProducto(id_producto));
        }

        public List<ProductoContract> ObtenerProductos()
        {
            return _mapper.Map<List<ProductoContract>>(_productoRepository.ObtenerProductos());

        }

        public ProductoContract Update(ProductoContract contract)
        {
            ProductoEntity entity = _productoRepository.ObtenerProducto(contract.id_producto);
            if (entity != null)
            {
                ProductoEntity productoEntity = _mapper.Map<ProductoEntity>(contract);
                return _mapper.Map<ProductoContract>(productoEntity);
            }
            else
            {
                return null;
            }
        }
    }
}
