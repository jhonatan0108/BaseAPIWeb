using EcommerceAPI.Comunes.Classes.Contracts.Ecommerce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceAPI.Dominio.Services.Ecommerce.Compras
{
    public interface ICompraService
    {

        CompraContract Create(CompraContract contract);
        CompraContract Update(CompraContract contract);
        List<CompraContract> GetAll();
        bool Delete(int id);
        CompraContract GetById(int id);
    }
}
