using AutoMapper;
using EcommerceAPI.Comunes.Classes.Contracts.Ecommerce;
using EcommerceAPI.Infraestructura.Database.Entities;
using EcommerceAPI.Infraestructura.Repositorios.Facturas;

namespace EcommerceAPI.Dominio.Services.Ecommerce.Facturas
{
    public class FacturaService: IFacturasService
    {
        private readonly IFacturaRepository _facturaRepository;
        private readonly IMapper _mapper;
        public FacturaService(IFacturaRepository facturaRepository, IMapper mapper) {
            _facturaRepository = facturaRepository;
            _mapper = mapper;
        }

        public FacturaContract Crear(FacturaContract contract)
        {
            FacturaEntity entity = _mapper.Map<FacturaEntity>(contract);

            FacturaEntity entityResultado = _facturaRepository.Crear(entity);

            FacturaContract response = _mapper.Map<FacturaContract>(entityResultado);
            return response;
        }

        public bool Delete(int id)
        {
            FacturaEntity cliente = _facturaRepository.ObtenerFactura(id);
            if (cliente != null)
            {
                _facturaRepository.Delete(cliente);
                return true;
            }
            return false;
        }

        public List<FacturaContract> ObtenerFactura()
        {
            return _mapper.Map<List<FacturaContract>>(_facturaRepository.ObtenerFactura());

        }

        public FacturaContract ObtenerFactura(int id)
        {
            return _mapper.Map<FacturaContract>(_facturaRepository.ObtenerFactura(id));
        }

        public FacturaContract Update(FacturaContract contract)
        {
            FacturaEntity entidad = _facturaRepository.ObtenerFactura(contract.id_factura);
            if (entidad != null)
            {
                FacturaEntity entidadActualizar = _mapper.Map<FacturaEntity>(contract);
                return _mapper.Map<FacturaContract>(_facturaRepository.Update(entidadActualizar));
            }
            return null;
        }
    }
}
