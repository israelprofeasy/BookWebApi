namespace BookWebApi.AppModels.Models
{
    public class Book_Author : BaseEntity
    {
        public string BookId { get; set; }
        public Book Book { get; set; }
        public string AuthorId { get; set; }
        public Author Author { get; set; }

    }
}
