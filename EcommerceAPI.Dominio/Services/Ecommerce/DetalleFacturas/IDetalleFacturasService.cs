using EcommerceAPI.Comunes.Classes.Contracts.Ecommerce;

namespace EcommerceAPI.Dominio.Services.Ecommerce.DetalleFacturas
{
    public interface IDetalleFacturasService
    {
        List<DetalleFacturaContract> ObtenerDetalleFactura();
        DetalleFacturaContract ObtenerDetalleFactura(int id);
        DetalleFacturaContract Crear(DetalleFacturaContract contract);
        DetalleFacturaContract Update(DetalleFacturaContract contract);
        bool Delete(int id);
    }
}
