using System;

namespace GiftWishlist.Data.Models
{
    public class ItemWishlistSnapshot
    {
        public int Id { get; set; }
        public DateTime SnapshotTime { get; set; }
        public int QuantityOnHand { get; set; }
        public Item Item { get; set; }
    }
}