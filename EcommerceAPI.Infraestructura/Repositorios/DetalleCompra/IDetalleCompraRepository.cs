using EcommerceAPI.Infraestructura.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceAPI.Infraestructura.Repositorios.DetalleCompra
{
    public interface IDetalleCompraRepository
    {
        public List<DetalleCompraEntity> ObtenerDetalle();

        //CRUD
        public DetalleCompraEntity CrearDetalle(DetalleCompraEntity detalle);

        public DetalleCompraEntity BuscarDetalle(int idDetalle);

        public DetalleCompraEntity ActualizarCompra(DetalleCompraEntity detalle);

        void BorrarDetalle(DetalleCompraEntity detalle);  // xq no por ID

    }
}
