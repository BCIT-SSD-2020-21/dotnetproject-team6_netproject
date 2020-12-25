namespace GiftWishlist.Web.ViewModels
{
    public class ItemWishlistModel
    {
        public int Id { get; set; }
        public int QuantityOnHand { get; set; }
        public int IdealQuantity { get; set; }
        public ItemModel Item { get; set; }
    }
}