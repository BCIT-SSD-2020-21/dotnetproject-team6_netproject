using System;
using System.Collections.Generic;
using System.Linq;
using GiftWishlist.Data;
using GiftWishlist.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace GiftWishlist.Services.Wishlist
{
    public class WishlistService : IWishlistService
    {
        private readonly WishlistDbContext _db;
        private readonly ILogger<WishlistService> _logger;

        public WishlistService(WishlistDbContext dbContext, ILogger<WishlistService> logger)
        {
            _db = dbContext;
            _logger = logger;
        }
        
        
        public List<ItemWishlist> GetCurrentWishlist()
        {
            return _db.ItemWishlists
                .Include(iw => iw.Item)
                .ToList();
        }

        public ServiceResponse<ItemWishlist> UpdateUnitsAvailable(int id, int adjustment)
        {
            try
            {
                var wishlist = _db.ItemWishlists
                    .Include(wish => wish.Item)
                    .First(wish => wish.Item.Id == id);

                wishlist.QuantityOnHand += adjustment;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public ItemWishlist GetByItemId(int itemId)
        {
            throw new System.NotImplementedException();
        }

        public List<ItemWishlistSnapshot> GetSnapshotHistory()
        {
            throw new System.NotImplementedException();
        }
    }
}