using EcommerceAPI.Infraestructura.Database.Context;
using EcommerceAPI.Infraestructura.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceAPI.Infraestructura.Repositorios.Compras
{
    public class ComprasRepository : IComprasRepository
    {
        private readonly EcommerceContext _context;

        public ComprasRepository(EcommerceContext context)
        {
            _context = context;
        }

        public List<CompraEntity> ObtenerCompra() {

//           List<CompraEntity> Compras = new List<CompraEntity>()

            return _context.Compras.ToList();
        }


        //CRUD

        public CompraEntity CrearCompra(CompraEntity compra) {

            if (compra == null)
            {
                _context.Add(compra);
                _context.SaveChanges();
                return compra;
            }
            else {
                string mensaje = "Registro ya existe";
                throw new Exception(mensaje);
            }
        
        }

        public CompraEntity BuscarCompra(int idCompra) {
            
            return _context.Compras.Find(idCompra);
        }

        public CompraEntity ActualizarCompra(CompraEntity compra) {

            _context.Compras.Update(compra);
            _context.SaveChanges();
            return compra;
        }

        public void BorrarCompra(CompraEntity compra)  // xq no por ID
        {
            CompraEntity CompraBorrar = new CompraEntity();
            try
            {
                CompraBorrar = (CompraEntity)(from Compras in _context.Compras
                                                  where Compras.idCompra== compra.idCompra
                                                  select compra);
                _context.Remove(CompraBorrar);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                if (CompraBorrar == null)
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
