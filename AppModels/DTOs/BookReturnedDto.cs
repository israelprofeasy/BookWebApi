using System;

namespace BookWebApi.AppModels.DTOs
{
    public class BookReturnedDto
    {
        public string Id { get; set; }
        public string Title { get; set; }
        
        public string Description { get; set; }
        
        public string ISBN { get; set; }
        
        public DateTime PublishedAt { get; set; }
        
        public string Category { get; set; }
        public string Authors { get; set; }
        public UploadReturnedDto Upload { get; set; }

    }
}
