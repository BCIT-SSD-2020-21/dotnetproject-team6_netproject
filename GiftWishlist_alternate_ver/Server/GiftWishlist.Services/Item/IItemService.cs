using System.Collections.Generic;

namespace GiftWishlist.Services.Item
{
    public interface IItemService
    {
        List<Data.Models.Item> GetAllItems();
        Data.Models.Item GetItemById(int id);
        ServiceResponse<Data.Models.Item> CreateItem(Data.Models.Item item);
        
        ServiceResponse<Data.Models.Item> ArchiveItem(int id);

    }
}