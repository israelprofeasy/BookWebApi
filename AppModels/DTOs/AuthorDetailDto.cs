using System.Collections.Generic;

namespace BookWebApi.AppModels.DTOs
{
    public class AuthorDetailDto
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Booklist> Books { get; set; } = new List<Booklist>();




        public class Booklist
        {
            public string Id { get; set; }
            public string Title { get; set; }
        }
    }
}
