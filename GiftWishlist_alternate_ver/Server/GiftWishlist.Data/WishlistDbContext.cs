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
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Item>().HasData(new Item()
            {
                Id = 1,
                Name = "Test Item 1",
                Description = "Test Item 1 description",
                Price = 10.10M,
                ImageUrl = "http://placehold.it/750x500",
                ImageThumbnailUrl = "http://placehold.it/500x300",
                IsArchived = false
            });
            
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Item>().HasData(new Item()
            {
                Id = 2,
                Name = "Test Item 2",
                Description = "Test Item 2 description",
                Price = 100M,
                ImageUrl = "http://placehold.it/750x500",
                ImageThumbnailUrl = "http://placehold.it/500x300",
                IsArchived = false
            });
        }

    }
}