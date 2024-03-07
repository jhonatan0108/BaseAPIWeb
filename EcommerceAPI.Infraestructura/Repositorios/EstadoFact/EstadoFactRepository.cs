
using EcommerceAPI.Infraestructura.Database.Context;
using EcommerceAPI.Infraestructura.Database.Entities;

namespace EcommerceAPI.Infraestructura.Repositorios.EstadoFact
{
    public class EstadoFactRepository : IEstadoFactRepository
    {
        private readonly EcommerceContext _context;
        public EstadoFactRepository(EcommerceContext context)
        {
            _context = context;
        }
        public EstadoFactEntity Crear(EstadoFactEntity entidad)
        {
            _context.EstadoFactura.Add(entidad);
            _context.SaveChanges();
            return entidad;
        }

        public void Delete(EstadoFactEntity entidad)
        {
            _context.EstadoFactura.Remove(entidad);
            _context.SaveChanges();
        }

        public EstadoFactEntity ObtenerEstadoFact(string id)
        {
            return _context.EstadoFactura.Find(id);
        }

        public List<EstadoFactEntity> ObtenerEstadoFacts()
        {
            return _context.EstadoFactura.ToList();
        }

        public EstadoFactEntity Update(EstadoFactEntity entidad)
        {
            _context.EstadoFactura.Update(entidad);
            _context.SaveChanges();
            return entidad;
        }
    }
}
