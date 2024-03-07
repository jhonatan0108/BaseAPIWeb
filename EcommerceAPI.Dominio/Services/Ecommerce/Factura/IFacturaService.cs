
using EcommerceAPI.Comunes.Classes.Contracts.Ecommerce;
using EcommerceAPI.Infraestructura.Database.Entities;

namespace EcommerceAPI.Dominio.Services.Ecommerce.Factura
{
    public interface IFacturaService
    {
        List<FacturaContract> ObtenerFactura();
        FacturaContract ObtenerFactura(string id);
        FacturaContract Crear(FacturaContract contract);
        FacturaContract Update(FacturaContract contract);
        bool Delete(string id);
    }
}
