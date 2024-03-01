using EcommerceAPI.Infraestructura.Database.Context;
using EcommerceAPI.Infraestructura.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceAPI.Infraestructura.Repositorios.Productos
{
    public class ProductosRepository : IProductosRepository
    {
        private readonly EcommerceContext _context;

        public ProductosRepository(EcommerceContext context) {

            _context = context;
        }
       
        public ProductoEntity CrearProducto(ProductoEntity producto)
        {
            if (producto == null)
            {
                _context.Add(producto);
                _context.SaveChanges();
                return producto;
            }
            else
            {
                string mensaje = "Registro ya existe";
                throw new Exception(mensaje);
            }
        }

        public List<ProductoEntity> ObtenerProductos()
        {
            return _context.Productos.ToList();
        }
        public ProductoEntity ActualizarProducto(ProductoEntity producto)
        {
            _context.Productos.Update(producto);
            _context.SaveChanges();
            return producto;

        }
        public void BorrarProducto(ProductoEntity producto)
        {
            ProductoEntity ProductoBorrar = new ProductoEntity();
            try
            {
                ProductoBorrar = (ProductoEntity)(from Producto in _context.Productos
                                                where Producto.idProducto == producto.idProducto
                                                select Producto);
                _context.Remove(ProductoBorrar);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                if (ProductoBorrar == null)
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

        public ProductoEntity BuscarProducto(int id)
        {
            return _context.Productos.Find(id);
        }
    }
}
