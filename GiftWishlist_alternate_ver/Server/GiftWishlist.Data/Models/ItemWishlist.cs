namespace GiftWishlist.Data.Models
{
    public class ItemWishlist
    {
        public int Id { get; set; }
        public int QuantityOnHand { get; set; }
        public int IdealQuantity { get; set; }
        public Item Item { get; set; }
    }
}