using BookWebApi.AppModels.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;

namespace BookWebApi.AppModels.DTOs
{
    public class BookDetailDto
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
      
        [Required]
        public IFormFile BookCover { get; set; }
        [Required]
        public IFormFile Book { get; set; }
    }
}
