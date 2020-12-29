using GiftWishlist.Data.Models;
using GiftWishlist.Web.ViewModels;

namespace GiftWishlist.Web.Serialization    
{
    public static class ItemMapper
    {
        public static ItemModel SerializeProductModel(Data.Models.Item item)
        {
            return new ItemModel
            {
                Id = item.Id,
                Name = item.Name,
                Description = item.Description,
                Price = item.Price,
                ImageUrl = item.ImageUrl,
                ImageThumbnailUrl = item.ImageThumbnailUrl,
                IsArchived = item.IsArchived
            };
        }
        
        public static Data.Models.Item SerializeProductModel(ItemModel item)
        {
            return new Data.Models.Item
            {
                Id = item.Id,
                Name = item.Name,
                Description = item.Description,
                Price = item.Price,
                ImageUrl = item.ImageUrl,
                ImageThumbnailUrl = item.ImageThumbnailUrl
            };
        }
    }
}