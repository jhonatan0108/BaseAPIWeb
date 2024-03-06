using AutoMapper;
using EcommerceAPI.Comunes.Classes.Contracts.Ecommerce;
using EcommerceAPI.Infraestructura.Database.Entities;
using EcommerceAPI.Infraestructura.Repositorios.Compra;
using EcommerceAPI.Infraestructura.Repositorios.DetalleCompra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceAPI.Dominio.Services.Ecommerce.DetalleCompra
{
    internal class DetalleCompraService : IDetalleCompraService
    {
        private readonly IDetalleCompraRepository _repository;
        private readonly IMapper _mapper;


        public DetalleCompraService(
            IDetalleCompraRepository detallecompraRepository,
            IMapper mapper
            )
        {
            _repository = detallecompraRepository;
            _mapper = mapper;
        }


        public DetalleCompraContract Crear(DetalleCompraContract contract)
        {
            DetalleCompraEntity entity = _mapper.Map<DetalleCompraEntity>(contract);
            DetalleCompraEntity entityResultado = _repository.Crear(entity);

            DetalleCompraContract response = _mapper.Map<DetalleCompraContract>(entityResultado);
            return response;
        }

        public bool Delete(int id)
        {
            DetalleCompraEntity detallecompra = _repository.ObtenerDetalleCompra(id);
            if (detallecompra != null)
            {
                _repository.Delete(detallecompra);
                return true;
            }
            return false;
        }

        public List<DetalleCompraContract> GetAll()
        {
            throw new NotImplementedException();
        }

        public DetalleCompraContract ObtenerCompra(int id)
        {
            return _mapper.Map<DetalleCompraContract>(_repository.ObtenerDetalleCompra(id));
        }

        public List<DetalleCompraContract> ObtenerDetalleCompra()
        {
            return _mapper.Map<List<DetalleCompraContract>>(_repository.ObtenerDetalleCompra());
        }

        public DetalleCompraContract Update(DetalleCompraContract contract)
        {
            if (contract == null)
            {
                throw new ArgumentNullException(nameof(contract));
            }

            DetalleCompraEntity entidad = _repository.ObtenerDetalleCompra(contract.Id);

            if (entidad == null)
            {
                return null;
            }

            try
            {
                _mapper.Map(contract, entidad);
                _repository.Update(entidad);
                return _mapper.Map<DetalleCompraContract>(entidad);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
