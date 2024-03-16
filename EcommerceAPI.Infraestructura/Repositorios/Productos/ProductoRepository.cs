using EcommerceAPI.Infraestructura.Database.Context;
using EcommerceAPI.Infraestructura.Database.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceAPI.Infraestructura.Repositorios.Productos
{
    public class ProductoRepository : IProductoRepository
    {
        private readonly EcommerceContext _context;

        public ProductoRepository(EcommerceContext context)
        {
            _context = context;
        }

        public ProductoEntity Create(ProductoEntity entidad)
        {
            _context.Productos.Add(entidad);
            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                // Manejar la excepción aquí
                Console.WriteLine(ex.Message);
            }
            return entidad;
        }

        public void Delete(ProductoEntity entidad)
        {
            _context.Remove(entidad);
            _context.SaveChanges();
        }

        public List<ProductoEntity> GetAll()
        {
            return _context.Productos.ToList();
        }

        public ProductoEntity GetById(int id)
        {
            return _context.Productos.Find(id);
        }

        public ProductoEntity Update(ProductoEntity entidad)
        {
            _context.Update(entidad);
            _context.SaveChanges();
            return entidad;
        }
    }
}
