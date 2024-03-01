using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EcommerceAPI.Infraestructura.Database.Entities;

namespace EcommerceAPI.Infraestructura.Database
{
    public class Context : DbContext
    {
        public Context (DbContextOptions<Context> options)
            : base(options)
        {
        }
        public DbSet<EcommerceAPI.Infraestructura.Database.Entities.ClienteEntity> ClienteEntity { get; set; } = default!;
        public DbSet<EcommerceAPI.Infraestructura.Database.Entities.ProductoEntity> ProductoEntity { get; set; } = default!;
    }
}
