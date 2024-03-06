
using EcommerceAPI.Comunes.Classes.Contracts.Ecommerce;

namespace EcommerceAPI.Dominio.Services.Ecommerce.Facturas
{
    public interface IFacturasService
    {
        List<FacturaContract> ObtenerFactura();
        FacturaContract ObtenerFactura(int id);
        FacturaContract Crear(FacturaContract contract);
        FacturaContract Update(FacturaContract contract);
        bool Delete(int id);
    }
}
