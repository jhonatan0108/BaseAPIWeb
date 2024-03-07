
using EcommerceAPI.Infraestructura.Database.Entities;

namespace EcommerceAPI.Infraestructura.Repositorios.DetFactura
{
    public interface IDetFacturaRepository
    {
        List<DetFacturaEntity> ObtenerDetFactura();
        DetFacturaEntity ObtenerDetFactura(string id);
        DetFacturaEntity Crear(DetFacturaEntity entidad);
        DetFacturaEntity Update(DetFacturaEntity entidad);
        void Delete(DetFacturaEntity entidad);

    }
}
