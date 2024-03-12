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

        #endregion

        #region DBSets Producto

        public virtual DbSet<ProductoEntity> Productos { get; set; }
        #endregion

        #region DBSets Estado

        public virtual DbSet<EstadoEntity> Estados { get; set; }
        #endregion

        #region DBSets Compra

        public virtual DbSet<CompraEntity> Compras { get; set; }
        #endregion
    }
}
