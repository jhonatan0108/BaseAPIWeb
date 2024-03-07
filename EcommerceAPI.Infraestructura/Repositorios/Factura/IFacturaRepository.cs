

using EcommerceAPI.Infraestructura.Database.Entities;

namespace EcommerceAPI.Infraestructura.Repositorios.Factura
{
    public interface IFacturaRepository
    {
        List<FacturaEntity> ObtenerFactura();
        FacturaEntity ObtenerFactura(string id);
        FacturaEntity Crear(FacturaEntity entidad);
        FacturaEntity Update(FacturaEntity entidad);
        void Delete(FacturaEntity entidad);
    }
}
