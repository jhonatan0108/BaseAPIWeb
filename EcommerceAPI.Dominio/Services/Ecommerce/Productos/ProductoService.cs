using AutoMapper;
using EcommerceAPI.Comunes.Classes.Contracts.Ecommerce;
using EcommerceAPI.Dominio.Services.Encripcion;
using EcommerceAPI.Infraestructura.Database.Entities;
using EcommerceAPI.Infraestructura.Repositorios.Clientes;
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

        private readonly IProductoRepository _repository;//se comunica con esta interfaz pero esta clase no sabe cuAL ES LA IMPLEMENTACION NI EL CONTEXTO
        private readonly IMapper _mapper;

        public ProductoService(
           IProductoRepository productosRepository,
           IMapper mapper
           
           )
        {
            _repository = productosRepository;
            _mapper = mapper;
            
        }
        public ProductoContract Create(ProductoContract contract)
        {
            ProductoEntity pe =_mapper.Map<ProductoEntity>(contract);
            ProductoEntity peNw = _repository.Create(pe);
            ProductoContract response = _mapper.Map<ProductoContract>(peNw);
            return response;
        }

        public bool Delete(int id)
        {
            ProductoEntity p = _repository.GetById(id);
            if (p!=null)
            {
                _repository.Delete(p);
                return true;
            }
            return false;
        }

        public List<ProductoContract> GetAll()
        {
            return _mapper.Map < List<ProductoContract>>(_repository.GetAll()) ;
        }

        public ProductoContract GetById(int id)
        {
            ProductoEntity  p= _repository.GetById(id);
            if (p!=null)
            {
                return _mapper.Map<ProductoContract>(p);
            }
            return _mapper.Map<ProductoContract>(p);
        }

        public ProductoContract Update(ProductoContract contract)
        {
           ProductoEntity p = _repository.GetById(contract.id_producto);
            if (p!=null)
            {
                ProductoEntity pNw = _repository.Update(p);
                return _mapper.Map<ProductoContract>(pNw);
            }
            return null;
        }
    }
}
