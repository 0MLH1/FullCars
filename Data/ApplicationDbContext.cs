using FullCars.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FullCars.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Client> Clients { get; set; }

        // DbSet for Car
        public DbSet<Car> Cars { get; set; }

        // DbSet for Commande
        public DbSet<Commande> Commandes { get; set; }
        public DbSet<CartItems> CartItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Car>().HasData(
new Car { Id_car = 13, Marque = "Audi", Price = 48000, Description = "a1.png", N_Stock = 13 },
new Car { Id_car = 3, Marque = "BMW", Price = 35000, Description = "b1.png", N_Stock = 15 },
new Car { Id_car = 6, Marque = "BMW", Price = 42000, Description = "b2.jpg", N_Stock = 18 },
new Car { Id_car = 9, Marque = "BMW", Price = 38000, Description = "b3.jpg", N_Stock = 10 },
new Car { Id_car = 12, Marque = "BMW", Price = 32000, Description = "b4.jpg", N_Stock = 19 },
new Car { Id_car = 15, Marque = "BMW", Price = 37000, Description = "b5.jpg", N_Stock = 15 },
new Car { Id_car = 2, Marque = "Honda", Price = 22000, Description = "h1.jpg", N_Stock = 8 },
new Car { Id_car = 19, Marque = "Jaguar", Price = 35000, Description = "j1.jpg", N_Stock = 16 },
new Car { Id_car = 4, Marque = "Mercedes", Price = 40000, Description = "m1.jpg", N_Stock = 12 },
new Car { Id_car = 7, Marque = "Mercedes", Price = 38000, Description = "m2.jpg", N_Stock = 14 },
new Car { Id_car = 10, Marque = "Mercedes", Price = 45000, Description = "m3.jpg", N_Stock = 22 },
new Car { Id_car = 16, Marque = "Mercedes", Price = 42000, Description = "m4.jpg", N_Stock = 14 },
new Car { Id_car = 18, Marque = "Porsche", Price = 40000, Description = "p1.jpg", N_Stock = 12 },
new Car { Id_car = 1, Marque = "Toyota", Price = 25000, Description = "t1.jpg", N_Stock = 10 },
new Car { Id_car = 14, Marque = "Tesla", Price = 34000, Description = "te1.jpg", N_Stock = 11 },
new Car { Id_car = 5, Marque = "Volkswagen", Price = 28000, Description = "v1.jpg", N_Stock = 20 },
new Car { Id_car = 8, Marque = "Volkswagen", Price = 32000, Description = "v2.jpg", N_Stock = 16 },
new Car { Id_car = 11, Marque = "Volkswagen", Price = 30000, Description = "v3.png", N_Stock = 17 },
new Car { Id_car = 17, Marque = "Volkswagen", Price = 29000, Description = "v5.jpg", N_Stock = 18 },
new Car { Id_car = 20, Marque = "Volkswagen", Price = 33000, Description = "v6.jpg", N_Stock = 20 }
            );
        }
    }
}

