using Microsoft.EntityFrameworkCore;
using OnlineStore.Models;

namespace OnlineStore.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<CartProduct> CartProducts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var user1 = new User { Id = 1, Username = "admin", Password = "admin" };
            modelBuilder.Entity<User>().HasData(user1);

            var p1 = new Product { Id = 1, Name = "Audifonos sony", Price = 10000, Amount = 10 };
            var p2 = new Product { Id = 2, Name = "Celular samsung", Price = 20000.50M, Amount = 15 };
            var p3 = new Product { Id = 3, Name = "Jarra", Price = 20, Amount = 20 };
            var p4 = new Product { Id = 4, Name = "Vaso", Price = 5, Amount = 10 };
            modelBuilder.Entity<Product>().HasData(p1,p2,p3,p4);

            base.OnModelCreating(modelBuilder);
        }

    }
}
