namespace GiftWishlist.Data.Models
{
    public class ItemWishlistSnapshot
    {
        public int Id { get; set; }
        public int QuantityOnHand { get; set; }
        public Item Item { get; set; }
    }
}