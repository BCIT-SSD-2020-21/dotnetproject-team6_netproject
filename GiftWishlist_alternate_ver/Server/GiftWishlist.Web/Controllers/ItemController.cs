using System.Linq;
using GiftWishlist.Services.Item;
using GiftWishlist.Web.Serialization;
using GiftWishlist.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Logging;

namespace GiftWishlist.Web.Controllers
{
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly ILogger<ItemController> _logger;
        private readonly IItemService _itemService;

        public ItemController(ILogger<ItemController> logger, IItemService itemService)
        {
            _logger = logger;
            _itemService = itemService;
        }

        [HttpGet("/api/items")]
        public ActionResult GetItem()
        {
            _logger.LogInformation("Getting all Items");
            var items = _itemService.GetAllItems();
            var itemViewModels = items
                .Select(ItemMapper.SerializeProductModel);
            return Ok(itemViewModels);
        }

        [HttpPost("/api/items")]
        public ActionResult AddItem([FromBody] ItemModel item)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            
            _logger.LogInformation("Adding item");
            var newItem = ItemMapper.SerializeProductModel(item);
            var newItemResponse = _itemService.CreateItem(newItem);
            return Ok(newItemResponse);
        }
        
        [HttpPatch("/api/items/{id}")]
        public ActionResult ArchiveProduct(int id)
        {
            _logger.LogInformation("Archiving item");
            var archiveResult = _itemService.ArchiveItem(id);
            return Ok(archiveResult);

        }

    }
}