using EcommerceAPI.Infraestructura.Database.Context;
using EcommerceAPI.Infraestructura.Database.Entities;

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
            _context.Estado.Remove(entidad);
            _context.SaveChanges();
        }

        public List<EstadoEntity> ObtenerEstados()
        {
            return _context.Estado.ToList(); 
        }

        public EstadoEntity ObtenerEstados(int id)
        {
            return _context.Estado.Find(id);
        }

        public EstadoEntity Update(EstadoEntity entidad)
        {
            _context.Estado.Update(entidad);
            _context.SaveChanges();
            return entidad;
        }
    }
}
