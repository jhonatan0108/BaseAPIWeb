
using EcommerceAPI.Comunes.Classes.Contracts.Ecommerce;
using EcommerceAPI.Infraestructura.Database.Entities;

namespace EcommerceAPI.Dominio.Services.Ecommerce.DeFactura
{
    public interface IDetFacturaService
    {
        List<DetFacturaContract> ObtenerDetFactura();
        DetFacturaContract ObtenerDetFactura(string id);
        DetFacturaContract Crear(DetFacturaContract contract);
        DetFacturaContract Update(DetFacturaContract contract);
        bool Delete(string id);
    }
}
