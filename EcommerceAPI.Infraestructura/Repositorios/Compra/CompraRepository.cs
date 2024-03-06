

using EcommerceAPI.Infraestructura.Database.Context;
using EcommerceAPI.Infraestructura.Database.Entities;


namespace EcommerceAPI.Infraestructura.Repositorios.Compra
{
    public class CompraRepository : ICompraRepository
    {
        private readonly EcommerceContext _context;
        public CompraRepository(EcommerceContext context)
        {
            _context = context;
        }




        public CompraEntity Crear(CompraEntity entidad)
        {
            _context.Compra.Add(entidad);
            _context.SaveChanges();
            return entidad;
        }

       

        public void Delete(CompraEntity entidad)
        {
            _context.Compra.Remove(entidad);
            _context.SaveChanges();
        }


        public List<CompraEntity> ObtenerCompra()
        {
            return _context.Compra.ToList();
        }

        public CompraEntity ObtenerCompra(int id)
        {
            return _context.Compra.Find(id);
        }

        public CompraEntity ObtenerCompra(object id)
        {
            throw new NotImplementedException();
        }

        public CompraEntity Update(CompraEntity entidad)
        {
            _context.Compra.Update(entidad);
            _context.SaveChanges();
            return entidad;
        }

        void ICompraRepository.Update(CompraEntity entidad)
        {
            throw new NotImplementedException();
        }
    }
}
