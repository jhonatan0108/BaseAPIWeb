using EcommerceAPI.Comunes.Clases.Contracts.Ecommerce;
using EcommerceAPI.Infraestructura.Database.Context;
using EcommerceAPI.Infraestructura.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceAPI.Infraestructura.Repositorios.Estados
{
    public class EstadoRepository : IEstadoRepository
    {

        private readonly EcommerceContext _context;
        public EstadoRepository(EcommerceContext context)
        {
            _context = context;
        }

        public EstadoEntity Crear(EstadoEntity entidad)
        {
            _context.Add(entidad);
            _context.SaveChanges();
            return entidad;
        }

        public void Delete(EstadoEntity entidad)
        {
            _context.Estados.Remove(entidad);
            _context.SaveChanges();
        }

        public EstadoEntity ObtenerEstado(int id_estado)
        {
            return _context.Estados.Find(id_estado);
        }
    

        public List<EstadoEntity> ObtenerEstados()
        {
            return _context.Estados.ToList();
        }

        public EstadoEntity Update(EstadoEntity entidad)
        {
            _context.Estados.Update(entidad);
            _context.SaveChanges();
            return entidad;
        }
    }
}
