using AutoMapper;
using EcommerceAPI.Comunes.Classes.Contracts.Ecommerce;
using EcommerceAPI.Infraestructura.Database.Entities;
using EcommerceAPI.Infraestructura.Repositorios.Clientes;
using EcommerceAPI.Infraestructura.Repositorios.DetallesFacturas;

namespace EcommerceAPI.Dominio.Services.Ecommerce.DetalleFacturas
{
    public class DetalleFacturasService : IDetalleFacturasService
    {
        private readonly IDetalleFacturaRepository _repository;
        private readonly IMapper _mapper;

        public DetalleFacturasService(IDetalleFacturaRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public DetalleFacturaContract Crear(DetalleFacturaContract contract)
        {
            DetallesFacturaEntity entity = _mapper.Map<DetallesFacturaEntity>(contract);

            DetallesFacturaEntity entityResultado = _repository.Crear(entity);

            DetalleFacturaContract response = _mapper.Map<DetalleFacturaContract>(entityResultado);
            return response;
        }

        public bool Delete(int id)
        {
            DetallesFacturaEntity cliente = _repository.ObtenerDetalleFactura(id);
            if (cliente != null)
            {
                _repository.Delete(cliente);
                return true;
            }
            return false;
        }

        public List<DetalleFacturaContract> ObtenerDetalleFactura()
        {
            return _mapper.Map<List<DetalleFacturaContract>>(_repository.ObtenerDetalleFactura());
        }

        public DetalleFacturaContract ObtenerDetalleFactura(int id)
        {
            return _mapper.Map<DetalleFacturaContract>(_repository.ObtenerDetalleFactura(id));
        }

        public DetalleFacturaContract Update(DetalleFacturaContract contract)
        {
            DetallesFacturaEntity entidad = _repository.ObtenerDetalleFactura(contract.id_producto);
            if (entidad != null)
            {
                DetallesFacturaEntity entidadActualizar = _mapper.Map<DetallesFacturaEntity>(contract);
                return _mapper.Map<DetalleFacturaContract>(_repository.Update(entidadActualizar));
            }
            return null;
        }
    }
}
