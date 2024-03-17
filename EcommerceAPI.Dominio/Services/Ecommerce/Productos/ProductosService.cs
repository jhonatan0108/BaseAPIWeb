using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcommerceAPI.Comunes.Classes.Contracts.Ecommerce;
using EcommerceAPI.Infraestructura.Repositorios.Productos;
using AutoMapper;
using EcommerceAPI.Infraestructura.Database.Entities;
using System.Security.Authentication;
using System.Diagnostics.Contracts;

namespace EcommerceAPI.Dominio.Services.Ecommerce.Productos
{
    public class ProductosService : IProductosService
    {

        private readonly IProductosRepository _repository;
        private readonly IMapper _mapper;

        public ProductosService(
            IProductosRepository ProductosRepository, IMapper mapper)
        {
            _repository = ProductosRepository;
            _mapper = mapper;
        }
        public ProductoContract CrearProducto(ProductoContract producto)
        {
            ProductoEntity Existe = _repository.BuscarProducto(producto.idProducto);
            if (Existe == null)
            {
                ProductoEntity entity = _mapper.Map<ProductoEntity>(producto);
                ProductoContract response = _mapper.Map<ProductoContract>(_repository.CrearProducto(entity));//.Crear(entity));
                return response;
            }
            else
            {
                return null;
            }
        }
        public ProductoContract BuscarProducto(Int32 id) {
          
                ProductoEntity entidad = _repository.BuscarProducto(id);
                ProductoContract response = _mapper.Map<ProductoContract>(entidad);
                return response;
            }
    
        public List<ProductoContract> ObtenerProductos() {

            return _mapper.Map<List<ProductoContract>>(_repository.ObtenerProductos()); 

        }
        public ProductoContract ActualizarProducto(ProductoContract contract)  {
            
            ProductoEntity entity = _repository.BuscarProducto(contract.idProducto);
            if (entity != null)
            {
                ProductoEntity entidadActualizar = _mapper.Map<ProductoEntity>(contract);
                return _mapper.Map<ProductoContract>(_repository.ActualizarProducto(entidadActualizar));
            }
            else
            {
                return null;
            }
        }
        public bool BorrarProducto(Int32 id) {

            ProductoEntity entidad = _repository.BuscarProducto(id);
            if (entidad != null)
            {
                _repository.BorrarProducto(entidad);
                return true;
            }
            return false; 
        }
    }
}
