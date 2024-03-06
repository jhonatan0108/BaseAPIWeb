using EcommerceAPI.Infraestructura.Database.Context;
using EcommerceAPI.Infraestructura.Database.Entities;

namespace EcommerceAPI.Infraestructura.Repositorios.DetallesFacturas
{
    public class DetalleFacturaRepository : IDetalleFacturaRepository
    {
        private readonly EcommerceContext _context;
        public DetalleFacturaRepository(EcommerceContext context)
        {
            _context = context;
        }
        public DetallesFacturaEntity Crear(DetallesFacturaEntity entidad)
        {
            _context.DetallesFactura.Add(entidad);
            _context.SaveChanges();
            return entidad;
        }

        public void Delete(DetallesFacturaEntity entidad)
        {
            _context.DetallesFactura.Remove(entidad);
            _context.SaveChanges();
        }

        public List<DetallesFacturaEntity> ObtenerDetalleFactura()
        {
            return _context.DetallesFactura.ToList();
        }

        public DetallesFacturaEntity ObtenerDetalleFactura(int id)
        {
            return _context.DetallesFactura.Find(id);
        }

        public DetallesFacturaEntity Update(DetallesFacturaEntity entidad)
        {
            _context.DetallesFactura.Update(entidad);
            _context.SaveChanges();
            return entidad;
        }
    }
}
