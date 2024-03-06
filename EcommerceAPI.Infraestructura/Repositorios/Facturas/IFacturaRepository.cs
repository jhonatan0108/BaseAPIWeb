using EcommerceAPI.Infraestructura.Database.Entities;

namespace EcommerceAPI.Infraestructura.Repositorios.Facturas
{
    public interface IFacturaRepository
    {
        List<FacturaEntity> ObtenerFactura();
        FacturaEntity ObtenerFactura(int id);
        FacturaEntity Crear(FacturaEntity entidad);
        FacturaEntity Update(FacturaEntity entidad);
        void Delete(FacturaEntity entidad);
    }
}
