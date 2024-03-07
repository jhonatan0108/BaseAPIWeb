
using EcommerceAPI.Infraestructura.Database.Context;
using EcommerceAPI.Infraestructura.Database.Entities;

namespace EcommerceAPI.Infraestructura.Repositorios.DetFactura
{
    public class DetFacturaRepository : IDetFacturaRepository
    {

        private readonly EcommerceContext _context;
        public DetFacturaRepository(EcommerceContext context)
        {
            _context = context;
        }

        public DetFacturaEntity Crear(DetFacturaEntity entidad)
        {
            _context.DetFactura.Add(entidad);
            _context.SaveChanges();
            return entidad;
        }

        public void Delete(DetFacturaEntity entidad)
        {
            _context.DetFactura.Remove(entidad);
            _context.SaveChanges();
        }

        public List<DetFacturaEntity> ObtenerDetFactura()
        {
            return _context.DetFactura.ToList();
        }

        public DetFacturaEntity ObtenerDetFactura(string id)
        {
            return _context.DetFactura.Find(id);
        }

        public DetFacturaEntity Update(DetFacturaEntity entidad)
        {
            _context.DetFactura.Update(entidad);
            _context.SaveChanges();
            return entidad;
        }
    }
}
