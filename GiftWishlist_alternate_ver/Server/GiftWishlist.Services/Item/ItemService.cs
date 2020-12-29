using System;
using System.Collections.Generic;
using System.Linq;
using GiftWishlist.Data;
using GiftWishlist.Data.Models;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace GiftWishlist.Services.Item
{
    public class ItemService : IItemService
    {
        private readonly WishlistDbContext _db;
        
        public ItemService(WishlistDbContext dbContext)
        {
            _db = dbContext;
        }
        
        
        public List<Data.Models.Item> GetAllItems()
        {
            return _db.Items.ToList();
        }

        public Data.Models.Item GetItemById(int id)
        {
            return _db.Items.Find(id);
        }

        public ServiceResponse<Data.Models.Item> CreateItem(Data.Models.Item item)
        {
            try
            {
                _db.Items.Add(item);

                var newItem = new ItemWishlist
                {
                    Item = item,
                    QuantityOnHand = 0,
                    IdealQuantity = 10,
                };

                _db.ItemWishlists.Add(newItem);
                _db.SaveChanges();

                return new ServiceResponse<Data.Models.Item>
                {
                    Data = item,
                    Time = DateTime.UtcNow,
                    Message = "Saved new product",
                    IsSuccess = true
                };
            }
            catch (Exception e)
            {
                return new ServiceResponse<Data.Models.Item>
                {
                    Data = item,
                    Time = DateTime.UtcNow,
                    Message = e.StackTrace,
                    IsSuccess = false
                };
            }
        }

        public ServiceResponse<Data.Models.Item> ArchiveItem(int id)
        {
            try
            {
                var product = _db.Items.Find(id);
                product.IsArchived = true;
                _db.SaveChanges();

                return new ServiceResponse<Data.Models.Item>
                {
                    Data = product,
                    Time = DateTime.UtcNow,
                    Message = "Item archived",
                    IsSuccess = true
                };
            }
            catch (Exception e)
            {
                return new ServiceResponse<Data.Models.Item>
                {
                    Data = null,
                    Time = DateTime.UtcNow,
                    Message = e.StackTrace,
                    IsSuccess = false
                };
            }        
        }
    }
}