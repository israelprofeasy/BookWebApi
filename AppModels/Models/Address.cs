using System.ComponentModel.DataAnnotations;

namespace BookWebApi.AppModels.Models
{
    public class Address
    {
        [Key]
        public string AppUserId { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public AppUser AppUser { get; set; }
    }
}
