using BookWebApi.AppModels.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookWebApi.AppDataAccess.Repositories.Interfaces
{
    public interface IBook_AuthorRepository : ICRUDRepository
    {
        Task<IEnumerable<Book>> BooksOfAuthor(string authorId);
        Task<IEnumerable<Author>> AuthorsOfBook(string bookId);
        Task<Book_Author> GetBook_Author(string bookId, string authorId);
    }
}
