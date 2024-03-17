using EcommerceAPI.Infraestructura.Database.Context;
using EcommerceAPI.Infraestructura.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceAPI.Infraestructura.Repositorios.DetalleCompra
{
    public class DetalleCompraRepository : IDetalleCompraRepository
    {
        private readonly EcommerceContext _context;

        public DetalleCompraRepository(EcommerceContext context)
        {
            _context = context;
        }
        public DetalleCompraEntity BuscarDetalle(int idDetalle)
        {
            return _context.DetalleCompra.Find(idDetalle);
        }

        public DetalleCompraEntity CrearDetalle(DetalleCompraEntity detalle)
        {
            if (detalle == null)
            {

                _context.Add(detalle);
                _context.SaveChanges();
                return detalle;
            }
            else
            {
                string mensaje = "Registro ya existe";
                throw new Exception(mensaje);
            }
        }

        public List<DetalleCompraEntity> ObtenerDetalle()
        {
            return _context.DetalleCompra.ToList();
        }
        public DetalleCompraEntity ActualizarCompra(DetalleCompraEntity detalle)
        {
            _context.DetalleCompra.Update(detalle);
            _context.SaveChanges();
            return detalle;
        }

        public void BorrarDetalle(DetalleCompraEntity detalle)
        {
            DetalleCompraEntity DetalleBorrar = new DetalleCompraEntity();

            try
            {
                DetalleBorrar = (DetalleCompraEntity)(from DetalleCompra in _context.DetalleCompra
                                                      where DetalleCompra.idCompra == detalle.idDetalle
                                                      select DetalleCompra);

                _context.Remove(DetalleBorrar);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                if (DetalleBorrar == null)
                {
                    string mensaje = "El registro no existe";
                    throw new Exception(mensaje);
                }
                else
                {
                    e.ToString();
                }

            }

        }
    }
}
