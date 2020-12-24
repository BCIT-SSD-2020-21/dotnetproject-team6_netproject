using GiftWishlist.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GiftWishlist.Data
{
    public class WishlistDbContext : IdentityDbContext
    {
        
        public WishlistDbContext()
        { }
        
        public WishlistDbContext(DbContextOptions options) : base(options)
        { }
        
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<ItemWishlist> ItemWishlists { get; set; }
        public virtual DbSet<ItemWishlistSnapshot> ItemWishlistSnapshots { get; set; }
        
        // Seed Wishlist
        
        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     base.OnModelCreating(modelBuilder);
        //     modelBuilder.Entity<Product>().HasData(new Product
        //     {
        //         Id = 1,
        //         Name = "Test Product 1",
        //         Description = "Test Product 1 description",
        //         Price = 10.10M,
        //         IsTaxable = true,
        //         IsArchived = false
        //     });
        // }

    }
}