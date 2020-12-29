using System.Linq;
using GiftWishlist.Services.Wishlist;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GiftWishlist.Web.Serialization;
using GiftWishlist.Web.ViewModels;

namespace GiftWishlist.Web.Controllers
{
    [ApiController]
    public class WishlistController : ControllerBase
    {
        private readonly IWishlistService _wishlistService;
        private readonly ILogger<WishlistController> _logger;

        public WishlistController(ILogger<WishlistController> logger, IWishlistService wishlistService)
        {
            _wishlistService = wishlistService;
            _logger = logger;
        }

        [HttpGet("/api/wishlist")]
        public ActionResult GetCurrentWishlist()
        {
            _logger.LogInformation("Getting all wishlist...");
            var wishlist = _wishlistService.GetCurrentWishlist()
                .Select(iw => new ItemWishlistModel
                {
                    Id = iw.Id,
                    Item = ItemMapper.SerializeProductModel(iw.Item),
                    IdealQuantity = iw.IdealQuantity,
                    QuantityOnHand = iw.QuantityOnHand
                })
                .OrderBy(wishlist => wishlist.Item.Name)
                .ToList();

            return Ok(wishlist);
        }
        
        
    }
}