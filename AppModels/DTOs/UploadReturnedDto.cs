namespace BookWebApi.AppModels.DTOs
{
    public class UploadReturnedDto
    {
        public string Id { get; set; }
        public string BookUrl { get; set; }
        public string CoverUrl { get; set; }
        public string BookPublicId { get; set; }
        public string CoverPublicId { get; set; }

    }
}
