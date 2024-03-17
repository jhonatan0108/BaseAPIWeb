using AutoMapper;
using EcommerceAPI.Comunes.Classes.Contracts.Ecommerce;
using EcommerceAPI.Infraestructura.Repositorios.Compras;
using EcommerceAPI.Infraestructura.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace EcommerceAPI.Dominio.Services.Ecommerce.Compras
{
    public class CompraService : ICompraService
    {

        private readonly IComprasRepository _repository;
        private readonly IMapper _mapper;

        public CompraService(
        IComprasRepository ComprasRepository, IMapper mapper)
        {
            _repository = ComprasRepository;
            _mapper = mapper;
        }
        public CompraContract ActualizarCompra(CompraContract compra)
        {
            CompraEntity Existe = _repository.BuscarCompra(compra.idCompra);
            if (Existe != null)
            {
                CompraEntity entidadActualizar = _mapper.Map<CompraEntity>(compra);
                return _mapper.Map<CompraContract>(_repository.ActualizarCompra(entidadActualizar));
            }
            else
            {
                return null;
            }
        }

        public bool BorrarCompra(int idCompra)
        {
            CompraEntity entidad = _repository.BuscarCompra(idCompra);
            if (entidad != null)
            {
                _repository.BorrarCompra(entidad);

                return true;
            }
            return false;
        }

        public CompraContract BuscarCompra(int idCompra)
        {
            CompraEntity entidad = _repository.BuscarCompra(idCompra);
            CompraContract Compra = _mapper.Map <CompraContract>(entidad);
            return Compra;
        }

        public CompraContract CrearCompra(CompraContract compra)
        {
            CompraEntity Existe = _repository.BuscarCompra(compra.idCompra);
            
            if (Existe == null)
            {
                CompraEntity Entity = _mapper.Map<CompraEntity>(compra);
                CompraContract response = _mapper.Map<CompraContract>(_repository.CrearCompra(Entity));
                return response;
            }
            else
            {
                return null;
            }
        }

        public List<CompraContract> ObtenerCompra()
        {
            return _mapper.Map<List<CompraContract>>(_repository.ObtenerCompra());
        }
    }
}
