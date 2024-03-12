using AutoMapper;
using EcommerceAPI.Comunes.Clases.Contracts.Ecommerce;
using EcommerceAPI.Comunes.Classes.Contracts.Ecommerce;
using EcommerceAPI.Infraestructura.Database.Entities;
using EcommerceAPI.Infraestructura.Repositorios.Compras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceAPI.Dominio.Services.Ecommerce.Compra
{
    public class CompraService : ICompraService
    {
        private readonly ICompraRepository _compraRepository;
        private readonly IMapper _mapper;

        public CompraService(ICompraRepository compraRepository, IMapper mapper )
        {
            _compraRepository = compraRepository;
            _mapper = mapper;
        }
        public CompraContract Crear(CompraContract contract)
        {
            CompraEntity entity = _mapper.Map<CompraEntity>(contract);
            entity = _compraRepository.Crear(entity);
            CompraContract response = _mapper.Map<CompraContract>(entity);
            return response;
        }

        public bool Delete(int id_compra)
        {
            CompraEntity compra = _compraRepository.ObtenerCompra(id_compra);
            if (compra != null)
            {
                _compraRepository.Delete(compra);
                return true;

            }
            return false;
        }

        public CompraContract ObtenerCompra(int id_compra)
        {
            return _mapper.Map<CompraContract>(_compraRepository.ObtenerCompra(id_compra));
        }

        public List<CompraContract> ObtenerCompras()
        {
            return _mapper.Map<List<CompraContract>>(_compraRepository.ObtenerCompras());
        }

            public CompraContract Update(CompraContract contract)
        {
            CompraEntity entidad = _compraRepository.ObtenerCompra(contract.id_compra);
            if (entidad != null)
            {

                CompraEntity entidadActualizar = _mapper.Map<CompraEntity>(contract);
                return _mapper.Map<CompraContract>(_compraRepository.Update(entidadActualizar));
            }
            else
            {
                return null;

            }
        }
    }
}
