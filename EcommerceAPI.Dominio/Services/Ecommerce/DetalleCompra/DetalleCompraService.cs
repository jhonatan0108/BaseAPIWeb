using AutoMapper;
using EcommerceAPI.Comunes.Classes.Contracts.Ecommerce;
using EcommerceAPI.Infraestructura.Database.Entities;
using EcommerceAPI.Infraestructura.Repositorios.DetalleCompra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceAPI.Dominio.Services.Ecommerce.DetalleCompra
{
    public class DetalleCompraService : IDetalleCompraService
    {

        private IDetalleCompraRepository _repository;
        private IMapper _mapper;

        public DetalleCompraService(
            IDetalleCompraRepository detalleCompraRepository, IMapper mapper)
        {
            _repository = detalleCompraRepository;
            _mapper = mapper;
        }
        public DetalleCompraContract ActualizarDetalle(DetalleCompraContract detalle)
        {
            
            DetalleCompraEntity Existe = _repository.BuscarDetalle(detalle.idDetalle);
            if (Existe != null) {
                DetalleCompraEntity entidadActualizar = _mapper.Map<DetalleCompraEntity>(detalle);
                return _mapper.Map<DetalleCompraContract>(_repository.ActualizarCompra(entidadActualizar));
            }
            else
            {
                return null;
            }
        }

        public bool BorrarDetalle(int detalle)
        {
            DetalleCompraEntity entidad = _repository.BuscarDetalle(detalle);
            if (entidad != null)
            {
                _repository.BorrarDetalle(entidad);

                return true;
            }
            return false;
        }

        public DetalleCompraContract BuscarDetalle(int idDetalle)
        {
            DetalleCompraEntity entidad = _repository.BuscarDetalle(idDetalle);
            DetalleCompraContract Compra = _mapper.Map<DetalleCompraContract>(entidad);
            return Compra;
        }

        public DetalleCompraContract CrearDetalle(DetalleCompraContract detalle)
        {
            DetalleCompraEntity entidad = _repository.BuscarDetalle(detalle.idDetalle);

            if (entidad == null)
            {
                DetalleCompraEntity Entity = _mapper.Map<DetalleCompraEntity>(detalle);
                DetalleCompraContract response = _mapper.Map<DetalleCompraContract>(_repository.CrearDetalle(Entity));
                return response;
            }
            else
            {
                return null;
            }
        }

        public List<DetalleCompraContract> ObtenerDetalle()
        {
            return _mapper.Map<List<DetalleCompraContract>>(_repository.ObtenerDetalle());
        }
    }
}
