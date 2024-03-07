using EcommerceAPI.Infraestructura.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace EcommerceAPI.Infraestructura.Database.Context
{
    public class EcommerceContext : DbContext
    {
        public EcommerceContext(DbContextOptions<EcommerceContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }

        #region DBSets
        public virtual DbSet<ClienteEntity> Clientes { get; set; }
        public virtual DbSet<ProductoEntity> Productos { get; set; }
        public virtual DbSet<EstadoFactEntity> EstadoFactura { get; set; }
        public virtual DbSet<FacturaEntity> Factura { get; set; }
        public virtual DbSet<EstadoProdEntity> EstadoProducto { get; set; }
        public virtual DbSet<DetFacturaEntity> DetFactura { get; set; }
        #endregion
    }
}
