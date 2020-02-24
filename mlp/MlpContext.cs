using mlp.Models;
using System;
using Microsoft.EntityFrameworkCore;

namespace mlp
{
    public class MlpContext : DbContext
    {
        private ModelBuilder modelBuilder;

        public DbSet<Product> Products { get; set; }

        public DbSet<Review> Reviews { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=Mlp;Trusted_Connection=True;";

            //var connectionString = "Server=DESKTOP-VRNV90S\\SQLEXPRESS;Database=Mlpdev;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
              .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Review>().HasData(
                new Review
                {
                    ReviewId = 1,
                    Content = "I love this pony!!",
                    ReviewerName = "Carl",
                    ProductId = 1,
                    Rating = 5.0,
                },
                new Review
                {
                    ReviewId = 2,
                    Content = "I love to feed my pony!!",
                    ReviewerName = "Amelia",
                    ProductId = 2,
                    Rating = 5.0,
                },
                new Review
                {
                    ReviewId = 3,
                    Content = "I love to ride my pony!!",
                    ReviewerName = "Colleen",
                    ProductId = 3,
                    Rating = 5.0,
                },
                new Review
                {
                    ReviewId = 4,
                    Content = "I wish I had this pony!!",
                    ReviewerName = "Tim",
                    ProductId = 4,
                    Rating = 5.0,
                },
                new Review
                {
                    ReviewId = 5,
                    Content = "I love collecting all sorts of ponies, but Rainbow Dash's colors are the best!!",
                    ReviewerName = "Nick",
                    ProductId = 1,
                    Rating = 5.0,
                },
                new Review
                {
                    ReviewId = 6,
                    Content = "She's sooooo cute and makes me really happy when I'm lonely (: Wish she talked more though...",
                    ReviewerName = "Alice",
                    ProductId = 2,
                    Rating = 4.0,
                },
                new Review
                {
                    ReviewId = 7,
                    Content = "Quite an impeccable product indeed, although I do feel compelled to point out minor fabric manufacturing issues in light of corners being potentially cut during production. That being said, Pinkie Pie is a total cutie that never ceases to melt my tender heart~ Hats off to the lovely souls at Hasbro for spreading the love!",
                    ReviewerName = "Chad",
                    ProductId = 3,
                    Rating = 4.5,
                },
                new Review
                {
                    ReviewId = 8,
                    Content = "She's sooooo cute and makes me really happy when I'm lonely (: Wish she talked more though...",
                    ReviewerName = "Mina",
                    ProductId = 4,
                    Rating = 3.5,
                }

                );

            modelbuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductId = 1,
                    Name = "Rainbow Dash",
                    Image = "rainbowdash.png",
                    Category = "Leader",
                    DateTimeGroup = DateTime.Now,
                    Description = "I am a strong Pony! Haaaaay!"
                },
                new Product
                {
                    ProductId = 2,
                    Name = "Fluttershy",
                    Image = "fluttershy.png",
                    Category = "Pony",
                    DateTimeGroup = DateTime.Now,
                    Description = "I am a shy Pony... hello!"
                },
                new Product
                {
                    ProductId = 3,
                    Name = "Pinkie Pie",
                    Image = "pinkypie.png",
                    Category = "Pony",
                    DateTimeGroup = DateTime.Now,
                    Description = "I am a fun Pony!!!"
                },
                new Product
                {
                    ProductId = 4,
                    Name = "Twilight Sparkle",
                    Image = "twilightsparkle.png",
                    Category = "Pony",
                    DateTimeGroup = DateTime.Now,
                    Description = "I am yet another pony, heya!"
                });

            base.OnModelCreating(modelBuilder);
        }
    }
}
