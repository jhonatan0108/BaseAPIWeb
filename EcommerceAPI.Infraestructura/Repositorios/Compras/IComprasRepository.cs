using EcommerceAPI.Infraestructura.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceAPI.Infraestructura.Repositorios.Compras
{
    public interface IComprasRepository
    {
        CompraEntity Create(CompraEntity entidad);
        CompraEntity Update(CompraEntity entidad);
        List<CompraEntity> GetAll();
        void Delete(CompraEntity entidad);
        CompraEntity GetById(int id);

    }
}
