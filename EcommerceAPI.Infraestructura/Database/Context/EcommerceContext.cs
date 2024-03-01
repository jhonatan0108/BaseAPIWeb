using EcommerceAPI.Infraestructura.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace EcommerceAPI.Infraestructura.Database.Context
{
    public class EcommerceContext : DbContext//esta clase se conecta a una bbdd
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
        public virtual DbSet<CompraEntity> Compras { get; set; }
        public virtual DbSet<EstadoEntity> Estados { get; set; }
        public virtual DbSet<ProductoEntity> Productos { get; set; }
        public virtual DbSet<StockEntity> Stocks { get; set; }

        #endregion

        
    }
}
