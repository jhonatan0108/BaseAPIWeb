

using EcommerceAPI.Comunes.Classes.Contracts.Ecommerce;

namespace EcommerceAPI.Dominio.Services.Ecommerce.Compra
{
    public interface ICompraService
    {
        List<CompraContract> ObtenerCompra();
        CompraContract ObtenerCompra(int id);
        CompraContract Crear(CompraContract contract);
        CompraContract Update(CompraContract contract);
        bool Delete(int id);
        List<CompraContract> GetAll();
    }
}
