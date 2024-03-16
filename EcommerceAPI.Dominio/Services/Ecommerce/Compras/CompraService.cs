using AutoMapper;
using EcommerceAPI.Comunes.Classes.Contracts.Ecommerce;
using EcommerceAPI.Infraestructura.Database.Entities;
using EcommerceAPI.Infraestructura.Repositorios.Compras;
using EcommerceAPI.Infraestructura.Repositorios.DetalleCompras;
using EcommerceAPI.Infraestructura.Repositorios.Productos;
using System.Runtime.CompilerServices;

namespace EcommerceAPI.Dominio.Services.Ecommerce.Compras
{
    public class CompraService : ICompraService
    {
        private readonly IComprasRepository _repository;//se comunica con esta interfaz pero esta clase no sabe cuAL ES LA IMPLEMENTACION NI EL CONTEXTO
        private readonly IMapper _mapper;
        private readonly IDetalleComprasRepository _repositoryDetalles;
        private readonly IProductoRepository _repositoryProducto;

        public CompraService(
            IComprasRepository repository,
            IMapper mapper,
            IDetalleComprasRepository repositoryDetalles,
            IProductoRepository repositoryProducto
            )
        {
            _repository = repository;
            _mapper = mapper;
            _repositoryDetalles = repositoryDetalles;
            _repositoryProducto = repositoryProducto;
        }
        public CompraContract Create(CompraContract contract)
        {
            CompraContract compra = _mapper.Map<CompraContract>
                ( _repository.Create(_mapper.Map<CompraEntity>(contract)));
            if (compra != null)
            {
                //Inserta detalles
                foreach (DetalleCompraContract detalle in contract.detalles)
                {
                    detalle.id_compra = compra.id_compra;
                   
                    DetalleCompraContract _detalle = _mapper.Map<DetalleCompraContract>
                        ( _repositoryDetalles.Create(_mapper.Map<DetalleCompraEntity>(detalle)));
                    if (_detalle != null)
                    {
                        _detalle.Producto = _mapper.Map<ProductoContract>
                            (_repositoryProducto.GetById(detalle.Producto.id_producto));
                        if (_detalle.Producto != null)
                        { 
                        compra.detalles.Add(_detalle);
                        }
                    }
                }
            }
            return compra;

        }
        public bool Delete(int id)
        {
            CompraEntity Cp = _repository.GetById(id);
            if (Cp != null)
            {
                _repository.Delete(Cp);
                return true;
            }
            return false;
        }

        public List<CompraContract> GetAll()
        {
            List<CompraContract> compras = _mapper.Map<List<CompraContract>>( _repository.GetAll());
            if (compras != null)
            {
                compras.ForEach(x =>
                {
                    x.detalles = _mapper.Map<List<DetalleCompraContract>>(_repositoryDetalles.GetById(x.id_compra));
                    x.detalles?.ForEach(y =>
                    {
                        y.Producto = _mapper.Map<ProductoContract>(_repositoryProducto.GetById(y.Producto.id_producto));
                      
                    });
                });
            }
            return compras;
        }

        public CompraContract GetById(int id) 
        {

            CompraContract compra = _mapper.Map<CompraContract>(_repository.GetById(id));
            if (compra != null)
            {
                compra.detalles = _mapper.Map<List<DetalleCompraContract>>(_repositoryDetalles.GetById(compra.id_compra));
                foreach (DetalleCompraContract detalle in compra.detalles)
                {
                    detalle.Producto = _mapper.Map<ProductoContract>( _repositoryProducto.GetById(detalle.Producto.id_producto));
                   
                }
            }
            return compra;
        }

        public CompraContract Update(CompraContract contract)
        {
            CompraContract compra = _mapper.Map<CompraContract>(_repository.Update(_mapper.Map<CompraEntity>(contract)));
            if (compra != null)
            {
                return  GetById(compra.id_compra);
            }
            return compra;
        }


    }

}
