using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcommerceAPI.Infraestructura.Database.Entities;


namespace EcommerceAPI.Infraestructura.Repositorios.Compras
{
    public interface IComprasRepository
    {
        //Listas Compras
        public List<CompraEntity> ObtenerCompra();

        //CRUD
        public CompraEntity CrearCompra(CompraEntity compra);

        public CompraEntity BuscarCompra(int idCompra);

        public CompraEntity ActualizarCompra(CompraEntity compra);

        void BorrarCompra(CompraEntity compra);  // xq no por ID


    }
}
