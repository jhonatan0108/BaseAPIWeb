using AutoMapper;
using EcommerceAPI.Comunes.Classes.Contracts.Ecommerce;
using EcommerceAPI.Infraestructura.Database.Entities;
using EcommerceAPI.Infraestructura.Repositorios.Estados;

namespace EcommerceAPI.Dominio.Services.Ecommerce.Estados
{
    public class EstadosService : IEstadosService
    {
        private readonly IEstadoRepository _estadoRepository;
        private readonly IMapper _mapper;
        public EstadosService(
            IEstadoRepository estadoRepository, 
            IMapper mapper
            ) {
            _estadoRepository = estadoRepository;
            _mapper = mapper;
        }
        public EstadoContract Crear(EstadoContract contract)
        {
            EstadoEntity entity = _mapper.Map<EstadoEntity>(contract);

            EstadoEntity entityResultado = _estadoRepository.Crear(entity);

            EstadoContract response = _mapper.Map<EstadoContract>(entityResultado);
            return response;
        }

        public bool Delete(int id)
        {
            EstadoEntity cliente = _estadoRepository.ObtenerEstados(id);
            if (cliente != null)
            {
                _estadoRepository.Delete(cliente);
                return true;
            }
            return false;
        }

        public List<EstadoContract> ObtenerEstado()
        {
            return _mapper.Map<List<EstadoContract>>(_estadoRepository.ObtenerEstados());
        }

        public EstadoContract ObtenerEstado(int id)
        {
            return _mapper.Map<EstadoContract>(_estadoRepository.ObtenerEstados(id));
        }

        public EstadoContract Update(EstadoContract contract)
        {
            EstadoEntity entidad = _estadoRepository.ObtenerEstados(contract.id_estado);
            if (entidad != null)
            {
                EstadoEntity entidadActualizar = _mapper.Map<EstadoEntity>(contract);
                return _mapper.Map<EstadoContract>(_estadoRepository.Update(entidadActualizar));
            }
            return null;
        }
    }
}
