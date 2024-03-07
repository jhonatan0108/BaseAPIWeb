
using EcommerceAPI.Infraestructura.Database.Context;
using EcommerceAPI.Infraestructura.Database.Entities;

namespace EcommerceAPI.Infraestructura.Repositorios.Factura
{
    public class FacturaRepository : IFacturaRepository
    {
        private readonly EcommerceContext _context;
        public FacturaRepository(EcommerceContext context)
        {
            _context = context;
        }
        public FacturaEntity Crear(FacturaEntity entidad)
        {
            _context.Factura.Add(entidad);
            _context.SaveChanges();
            return entidad;
        }

        public void Delete(FacturaEntity entidad)
        {
            _context.Factura.Remove(entidad);
            _context.SaveChanges();
        }

        public List<FacturaEntity> ObtenerFactura()
        {
            return _context.Factura.ToList();
        }

        public FacturaEntity ObtenerFactura(string id)
        {
            return _context.Factura.Find(id);
        }

        public FacturaEntity Update(FacturaEntity entidad)
        {
            _context.Factura.Update(entidad);
            _context.SaveChanges();
            return entidad;
        }
    }
}
