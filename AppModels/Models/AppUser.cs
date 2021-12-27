using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookWebApi.AppModels.Models
{
    public class AppUser : IdentityUser
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public bool IsActive { get; set; }
        public Address Address { get; set; } = new Address();
        public List<FavouriteBook> FavoriteBooks { get; set; } = new List<FavouriteBook>(); 
    }
}
