using EcommerceAPI.Infraestructura.Database.Entities;

namespace EcommerceAPI.Infraestructura.Repositorios.DetallesFacturas
{
    public interface IDetalleFacturaRepository
    {
        List<DetallesFacturaEntity> ObtenerDetalleFactura();
        DetallesFacturaEntity ObtenerDetalleFactura(int id);
        DetallesFacturaEntity Crear(DetallesFacturaEntity entidad);
        DetallesFacturaEntity Update(DetallesFacturaEntity entidad);
        void Delete(DetallesFacturaEntity entidad);
    }
}
