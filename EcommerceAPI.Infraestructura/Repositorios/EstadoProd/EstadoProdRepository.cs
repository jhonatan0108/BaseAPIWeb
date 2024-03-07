
using EcommerceAPI.Infraestructura.Database.Context;
using EcommerceAPI.Infraestructura.Database.Entities;

namespace EcommerceAPI.Infraestructura.Repositorios.EstadoProd
{
    public class EstadoProdRepository : IEstadoProdRepository
    {
        private readonly EcommerceContext _context;
        public EstadoProdRepository(EcommerceContext context)
        {
            _context = context;
        }

        public EstadoProdEntity Crear(EstadoProdEntity entidad)
        {
            _context.EstadoProducto.Add(entidad);
            _context.SaveChanges();
            return entidad;
        }

        public void Delete(EstadoProdEntity entidad)
        {
            _context.EstadoProducto.Remove(entidad);
            _context.SaveChanges();
        }

        public List<EstadoProdEntity> ObtenerEstadoProd()
        {
            return _context.EstadoProducto.ToList();
        }

        public EstadoProdEntity ObtenerEstadoProd(string id)
        {
            return _context.EstadoProducto.Find(id);
        }

        public EstadoProdEntity Update(EstadoProdEntity entidad)
        {
            _context.EstadoProducto.Update(entidad);
            _context.SaveChanges();
            return entidad;
        }
    }
}
