using Microsoft.AspNetCore.Http;

namespace BookWebApi.AppModels.DTOs
{
    public class UploadUpdateDto
    {
        public IFormFile BookCover { get; set; }
        
        public IFormFile Book { get; set; }
    }
}
