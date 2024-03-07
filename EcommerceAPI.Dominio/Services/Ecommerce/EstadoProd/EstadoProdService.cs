
using AutoMapper;
using EcommerceAPI.Comunes.Classes.Contracts.Ecommerce;
using EcommerceAPI.Infraestructura.Database.Entities;
using EcommerceAPI.Infraestructura.Repositorios.EstadoFact;
using EcommerceAPI.Infraestructura.Repositorios.EstadoProd;

namespace EcommerceAPI.Dominio.Services.Ecommerce.EstadoProd
{
    public class EstadoProdService : IEstadoProdService
    {

        private readonly IEstadoProdRepository _repository;
        private readonly IMapper _mapper;

        public EstadoProdService(
            IEstadoProdRepository estadoProdRepository,
            IMapper mapper)
        {
            _repository = estadoProdRepository;
            _mapper = mapper;
        }

        public EstadoProdContract Crear(EstadoProdContract contract)
        {
            EstadoProdEntity entity = _mapper.Map<EstadoProdEntity>(contract);

            EstadoProdEntity entityResultado = _repository.Crear(entity);

            EstadoProdContract response = _mapper.Map<EstadoProdContract>(entityResultado);
            return response;
        }

        public bool Delete(string id)
        {
            EstadoProdEntity estadoprod = _repository.ObtenerEstadoProd(id);
            if (estadoprod != null)
            {
                _repository.Delete(estadoprod);
                return true;
            }
            return false;
        }

        public List<EstadoProdContract> ObtenerEstadoProd()
        {
            return _mapper.Map<List<EstadoProdContract>>(_repository.ObtenerEstadoProd());
        }

        public EstadoProdContract ObtenerEstadoProd(string id)
        {
            return _mapper.Map<EstadoProdContract>(_repository.ObtenerEstadoProd(id));
        }

        public EstadoProdContract Update(EstadoProdContract contract)
        {
            EstadoProdEntity entidad = _repository.ObtenerEstadoProd(contract.valor_estado);

            if (entidad != null)
            {
                EstadoProdEntity entidadActualizar = _mapper.Map<EstadoProdEntity>(contract);
                return _mapper.Map<EstadoProdContract>(_repository.Update(entidadActualizar));
            }
            return null;
        }
    }
}
