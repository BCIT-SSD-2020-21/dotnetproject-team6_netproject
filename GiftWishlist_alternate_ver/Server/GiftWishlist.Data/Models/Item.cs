﻿using System.ComponentModel.DataAnnotations;

namespace GiftWishlist.Data.Models
{
    public class Item
    {
        public int Id { get; set; }
        [MaxLength(64)] 
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public bool IsArchived { get; set; }
    }
}