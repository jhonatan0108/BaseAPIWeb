using AutoMapper;
using EcommerceAPI.Comunes.Classes.Contracts.Ecommerce;
using EcommerceAPI.Infraestructura.Repositorios.Compras;
using EcommerceAPI.Infraestructura.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;
using EcommerceAPI.Infraestructura.Repositorios.DetalleCompra;
using EcommerceAPI.Infraestructura.Repositorios.Productos;

namespace EcommerceAPI.Dominio.Services.Ecommerce.Compras
{

    public class CompraService : ICompraService
    {

        private readonly IComprasRepository _repository;
        private readonly IDetalleCompraRepository _detalleCompraRepository;
        private readonly IProductosRepository _repositoryProductos;
        private readonly IMapper _mapper;

        public CompraService(
        IComprasRepository ComprasRepository, IDetalleCompraRepository detalleCompraRepository,  IMapper mapper,
            IProductosRepository productosRepository)
        {
            _repository = ComprasRepository;
            _detalleCompraRepository = detalleCompraRepository;
            _repositoryProductos = productosRepository;
            _mapper = mapper;
        }

        public async Task<CompraContract> CrearCompra(CompraContract compra)
        {
            CompraContract Existe = _mapper.Map<CompraContract>(await _repository.CrearCompra(_mapper.Map<CompraEntity>(compra))); //_repository.BuscarCompra(compra.idCompra);

            if (Existe != null)
            {
                foreach (DetalleCompraContract detalle in compra.detalles)
                { 
                    detalle.idCompra = compra.idCompra;
                    DetalleCompraContract _detalle = _mapper.Map<DetalleCompraContract>(await _detalleCompraRepository.CrearDetalle(_mapper.Map<DetalleCompraEntity>(detalle)));
                if (_detalle != null) {
                        _detalle.Producto = _mapper.Map<ProductoContract>(await _repositoryProductos.BuscarProducto(detalle.idProducto));
                        compra.detalles.Add(_detalle);
                    }
                }
                return compra;
            }
            else
            {
                return null;
            }
        }

        public List<CompraContract> ObtenerCompra()
        {
            return _mapper.Map<List<CompraContract>>(_repository.ObtenerCompra());
        }
        public CompraContract BuscarCompra(int idCompra)
        {
            CompraEntity entidad = _repository.BuscarCompra(idCompra);
            CompraContract Compra = _mapper.Map<CompraContract>(entidad);
            return Compra;
        }

        public async Task <CompraContract> ActualizarCompra(CompraContract compra)
        {
            CompraEntity Existe = _repository.BuscarCompra(compra.idCompra);
            if (Existe != null)
            {
                CompraEntity entidadActualizar = _mapper.Map<CompraEntity>(compra);
                return _mapper.Map<CompraContract>(_repository.ActualizarCompra(entidadActualizar));
            }
            else
            {
                return null;
            }
        }

        public bool BorrarCompra(int idCompra)
        {
            CompraEntity entidad = _repository.BuscarCompra(idCompra);
            if (entidad != null)
            {
                _repository.BorrarCompra(entidad);

                return true;
            }
            return false;
        }
    }
}
