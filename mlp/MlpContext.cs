using mlp.Models;
using System;
using Microsoft.EntityFrameworkCore;

namespace mlp
{
    public class MlpContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=MusicTesting;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
              .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }
    }
}
