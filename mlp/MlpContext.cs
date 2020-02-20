using mlp.Models;
using System;
using Microsoft.EntityFrameworkCore;

namespace mlp
{
    public class MlpContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DbSet<Review> Reviews { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //var connectionString = "Server=(localdb)\\mssqllocaldb;Database=Mlp;Trusted_Connection=True;";

            var connectionString = "Server=DESKTOP-VRNV90S\\SQLEXPRESS;Database=Mlpdev;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
              .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }
    }
}
