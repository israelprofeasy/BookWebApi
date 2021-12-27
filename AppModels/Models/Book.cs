using BookWebApi.AppModels.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookWebApi.AppModels.Models
{
    public class Book : BaseEntity 
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string ISBN { get; set; }
        [Required]
        public DateTime PublishedAt { get; set; }
        [Required]
        public string CategoryId { get; set; }
        public Category Category { get; set; }
        [Required]
       
        public Upload Upload { get; set; } = new Upload();
        public List<FavouriteBook> FavouriteUsers { get; set; } = new List<FavouriteBook>();
        public List<Book_Author> Book_Authors { get; set; } = new List<Book_Author>();

    }
}
