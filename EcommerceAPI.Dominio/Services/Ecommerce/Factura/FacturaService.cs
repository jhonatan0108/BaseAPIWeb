
using AutoMapper;
using EcommerceAPI.Comunes.Classes.Contracts.Ecommerce;
using EcommerceAPI.Infraestructura.Database.Entities;
using EcommerceAPI.Infraestructura.Repositorios.Factura;

namespace EcommerceAPI.Dominio.Services.Ecommerce.Factura
{
    public class FacturaService : IFacturaService
    {

        private readonly IFacturaRepository _repository;
        private readonly IMapper _mapper;
        public FacturaService(
            IFacturaRepository facturaRepository,
            IMapper mapper)
        {
            _repository = facturaRepository;
            _mapper = mapper;
        }

        public FacturaContract Crear(FacturaContract contract)
        {
            FacturaEntity entity = _mapper.Map<FacturaEntity>(contract);

            FacturaEntity entityResultado = _repository.Crear(entity);

            FacturaContract response = _mapper.Map<FacturaContract>(entityResultado);
            return response;
        }

        public bool Delete(string id)
        {
            FacturaEntity factura = _repository.ObtenerFactura(id);
            if (factura != null)
            {
                _repository.Delete(factura);
                return true;
            }
            return false;

        }

        public List<FacturaContract> ObtenerFactura()
        {
            return _mapper.Map<List<FacturaContract>>(_repository.ObtenerFactura());

        }

        public FacturaContract ObtenerFactura(string id)
        {
            return _mapper.Map<FacturaContract>(_repository.ObtenerFactura(id));
        }

        public FacturaContract Update(FacturaContract contract)
        {
            FacturaEntity entidad = _repository.ObtenerFactura(contract.num_factura);

            if (entidad != null)
            {
                FacturaEntity entidadActualizar = _mapper.Map<FacturaEntity>(contract);
                return _mapper.Map<FacturaContract>(_repository.Update(entidadActualizar));
            }
            return null;
        }
    }
}
