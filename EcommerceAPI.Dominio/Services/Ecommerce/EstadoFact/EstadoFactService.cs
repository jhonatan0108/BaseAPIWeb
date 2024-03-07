
using AutoMapper;
using EcommerceAPI.Comunes.Classes.Contracts.Ecommerce;
using EcommerceAPI.Infraestructura.Database.Entities;
using EcommerceAPI.Infraestructura.Repositorios.EstadoFact;

namespace EcommerceAPI.Dominio.Services.Ecommerce.EstadoFact
{
    public class EstadoFactService : IEstadoFactService
    {

        private readonly IEstadoFactRepository _repository;
        private readonly IMapper _mapper;

        public EstadoFactService(
            IEstadoFactRepository estadoFactRepository,
            IMapper mapper)
        {
            _repository = estadoFactRepository;
            _mapper = mapper;
        }
        public EstadoFactContract Crear(EstadoFactContract contract)
        {
            EstadoFactEntity entity = _mapper.Map<EstadoFactEntity>(contract);

            EstadoFactEntity entityResultado = _repository.Crear(entity);

            EstadoFactContract response = _mapper.Map<EstadoFactContract>(entityResultado);
            return response;
        }

        public bool Delete(string id)
        {
            EstadoFactEntity estadofact = _repository.ObtenerEstadoFact(id);
            if (estadofact != null)
            {
                _repository.Delete(estadofact);
                return true;
            }
            return false;

        }

        public EstadoFactContract ObtenerEstadoFact(string id)
        {
            return _mapper.Map<EstadoFactContract>(_repository.ObtenerEstadoFact(id));
        }

        public List<EstadoFactContract> ObtenerEstadoFacts()
        {
            return _mapper.Map<List<EstadoFactContract>>(_repository.ObtenerEstadoFacts());
        }

        public EstadoFactContract Update(EstadoFactContract contract)
        {
            EstadoFactEntity entidad = _repository.ObtenerEstadoFact(contract.valor_estado);

            if (entidad != null)
            {
                EstadoFactEntity entidadActualizar = _mapper.Map<EstadoFactEntity>(contract);
                return _mapper.Map<EstadoFactContract>(_repository.Update(entidadActualizar));
            }
            return null;
        }
    }
}
