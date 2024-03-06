

using EcommerceAPI.Comunes.Classes.Contracts.Ecommerce;

namespace EcommerceAPI.Dominio.Services.Ecommerce.DetalleCompra
{
    public interface IDetalleCompraService
    {
        List<DetalleCompraContract> ObtenerDetalleCompra();
        DetalleCompraContract ObtenerCompra(int id);
        DetalleCompraContract Crear(DetalleCompraContract contract);
        DetalleCompraContract Update(DetalleCompraContract contract);
        bool Delete(int id);
        List<DetalleCompraContract> GetAll();
    }
}
