using System;
using System.Collections.Generic;

namespace BookWebApi.AppModels.Models
{
    public class FavouriteBook
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public string BookId { get; set; }
        public Book Book { get; set; } 
    }
}
