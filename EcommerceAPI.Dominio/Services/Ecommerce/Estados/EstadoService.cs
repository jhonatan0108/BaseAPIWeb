using AutoMapper;
using EcommerceAPI.Comunes.Clases.Contracts.Ecommerce;
using EcommerceAPI.Comunes.Classes.Contracts.Ecommerce;
using EcommerceAPI.Infraestructura.Database.Entities;
using EcommerceAPI.Infraestructura.Repositorios.Estados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceAPI.Dominio.Services.Ecommerce.Estados
{
    public class EstadoService : IEstadoService
    {
        private readonly IEstadoRepository _estadoRepository;
        private readonly IMapper _mapper;
        public EstadoService(IEstadoRepository estadoRepository, IMapper mapper) { 

            _estadoRepository = estadoRepository;
            _mapper = mapper;
        }
        public EstadoContract Crear(EstadoContract contract)
        {
            EstadoEntity entity = _mapper.Map<EstadoEntity>(contract);
            entity = _estadoRepository.Crear(entity);
            EstadoContract response = _mapper.Map<EstadoContract>(entity);
            return response;
        }

        public bool Delete(int id_estado)
        {
            EstadoEntity entity = _estadoRepository.ObtenerEstado(id_estado);
            if (entity != null)
            {
                _estadoRepository.Delete(entity);
                return true;

            }
            return false;
        }

        public EstadoContract ObtenerEstado(int id_estado)
        {
            return _mapper.Map<EstadoContract>(_estadoRepository.ObtenerEstado(id_estado));
        }

        public List<EstadoContract> ObtenerEstados()
        {
            return _mapper.Map<List<EstadoContract>>(_estadoRepository.ObtenerEstados());
        }

        public EstadoContract Update(EstadoContract contract)
        {
            EstadoEntity entidad = _estadoRepository.ObtenerEstado(contract.id_estado);
            if (entidad != null)
            {

                EstadoEntity entidadActualizar = _mapper.Map<EstadoEntity>(contract);
                return _mapper.Map<EstadoContract>(_estadoRepository.Update(entidadActualizar));
            }
            else
            {
                return null;

            }
        }
    }
}
