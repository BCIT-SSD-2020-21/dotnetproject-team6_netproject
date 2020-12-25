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

                try
                {
                    CreateSnapshot(wishlist);
                }
                catch (Exception e)
                {
                    _logger.LogError("Error creating wishlist snapshot");
                    _logger.LogError(e.StackTrace);
                }

                _db.SaveChanges();

                return new ServiceResponse<ItemWishlist>
                {
                    IsSuccess = true,
                    Data = wishlist,
                    Message = $"Item {id} wishlist adjusted",
                    Time = DateTime.UtcNow
                };
            }
            catch
            {
                return new ServiceResponse<ItemWishlist>
                {
                    IsSuccess = false,
                    Data = null,
                    Message = "Error updating product inventory quantityonhand",
                    Time = DateTime.UtcNow
                };
            }

        }

        public ItemWishlist GetByItemId(int itemId)
        {
            return _db.ItemWishlists
                .Include(wi => wi.Item)
                .FirstOrDefault(wi => wi.Item.Id == itemId);
        }

        public List<ItemWishlistSnapshot> GetSnapshotHistory()
        {
            var earliest = DateTime.UtcNow - TimeSpan.FromHours(6);

            return _db.ItemWishlistSnapshots
                .Include(snap => snap.Item)
                .ToList();
        }


        private void CreateSnapshot(ItemWishlist wishlist)
        {
            var now = DateTime.UtcNow;

            var snapshot = new ItemWishlistSnapshot
            {
                SnapshotTime = now,
                Item = wishlist.Item,
                QuantityOnHand = wishlist.QuantityOnHand
            };

            _db.Add(snapshot);

        }
    }
}