using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookWebApi.AppModels.Models
{
    public class Upload
    {
        public string BookUrl { get; set; }
        public string CoverUrl { get; set; }
        public string BookPublicId { get; set; }
        public string CoverPublicId { get; set; }
        [Key]
        public string BookId { get; set; }
        public Book Book { get; set; }


    }
}
