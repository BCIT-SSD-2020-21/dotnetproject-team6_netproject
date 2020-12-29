using System.Collections.Generic;
using GiftWishlist.Data.Models;

namespace GiftWishlist.Services.Wishlist
{
    public interface IWishlistService
    {
        public List<ItemWishlist> GetCurrentWishlist();
        public ServiceResponse<ItemWishlist> UpdateUnitsAvailable(int id, int adjustment);
        public ItemWishlist GetByItemId(int itemId);
        public List<ItemWishlistSnapshot> GetSnapshotHistory();
        
    }
}