using System.Collections.Generic;

namespace BookWebApi.AppModels.Models
{
    public class Author : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Book_Author> Book_Authors { get; set; } = new List<Book_Author>();
    }
}
