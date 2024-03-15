using AutoMapper;
using EcommerceAPI.Comunes.Clases.Contracts.Ecommerce;
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
    public class DetalleService : IDetalleService
    {
        private readonly IDetalleRepository _repository;
        private readonly IMapper _mapper;

        public DetalleService(IDetalleRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;

        }
        public DetalleContract Crear(DetalleContract contract)
        {
            DetalleEntity entity = _mapper.Map<DetalleEntity>(contract);
            entity = _repository.Crear(entity);
            DetalleContract response = _mapper.Map<DetalleContract>(entity);
            return response;
        }

        public bool Delete(int id_detallecompra)
        {
            DetalleEntity detalle = _repository.ObtenerDetalleCompra(id_detallecompra);
            if (detalle != null)
            {
                _repository.Delete(detalle);
                return true;

            }
            return false;
        }

        public DetalleContract ObtenerDetalleCompra(int id_detallecompra)
        {
            return _mapper.Map<DetalleContract>(_repository.ObtenerDetalleCompra(id_detallecompra));
        }

        public List<DetalleContract> ObtenerDetalleCompras()
        {
            return _mapper.Map<List<DetalleContract>>(_repository.ObtenerDetalleCompras());
        }

        public DetalleContract Update(DetalleContract contract)
        {
            DetalleEntity entidad = _repository.ObtenerDetalleCompra(contract.id_detallecompra);
            if (entidad != null)
            {

                DetalleEntity entidadActualizar = _mapper.Map<DetalleEntity>(contract);
                return _mapper.Map<DetalleContract>(_repository.Update(entidadActualizar));
            }
            else
            {
                return null;

            }
        }
    }
}
