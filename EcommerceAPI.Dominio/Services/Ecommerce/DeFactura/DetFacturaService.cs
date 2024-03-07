
using AutoMapper;
using EcommerceAPI.Comunes.Classes.Contracts.Ecommerce;
using EcommerceAPI.Infraestructura.Database.Entities;
using EcommerceAPI.Infraestructura.Repositorios.DetFactura;


namespace EcommerceAPI.Dominio.Services.Ecommerce.DeFactura
{
    public class DetFacturaService : IDetFacturaService
    {
        private readonly IDetFacturaRepository _repository;
        private readonly IMapper _mapper;
        public DetFacturaService(
            IDetFacturaRepository detfacturaRepository,
            IMapper mapper)
        {
            _repository = detfacturaRepository;
            _mapper = mapper;
        }

        public DetFacturaContract Crear(DetFacturaContract contract)
        {
            DetFacturaEntity entity = _mapper.Map<DetFacturaEntity>(contract);

            DetFacturaEntity entityResultado = _repository.Crear(entity);

            DetFacturaContract response = _mapper.Map<DetFacturaContract>(entityResultado);
            return response;
        }

        public bool Delete(string id)
        {
            DetFacturaEntity detfactura = _repository.ObtenerDetFactura(id);
            if (detfactura != null)
            {
                _repository.Delete(detfactura);
                return true;
            }
            return false;
        }

        public List<DetFacturaContract> ObtenerDetFactura()
        {
            return _mapper.Map<List<DetFacturaContract>>(_repository.ObtenerDetFactura());
        }

        public DetFacturaContract ObtenerDetFactura(string id)
        {
            return _mapper.Map<DetFacturaContract>(_repository.ObtenerDetFactura(id));
        }

        public DetFacturaContract Update(DetFacturaContract contract)
        {
            DetFacturaEntity entidad = _repository.ObtenerDetFactura(contract.num_factura);

            if (entidad != null)
            {
                DetFacturaEntity entidadActualizar = _mapper.Map<DetFacturaEntity>(contract);
                return _mapper.Map<DetFacturaContract>(_repository.Update(entidadActualizar));
            }
            return null;
        }
    }
}
