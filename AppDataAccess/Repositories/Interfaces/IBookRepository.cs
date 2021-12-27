using BookWebApi.AppModels.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookWebApi.AppDataAccess.Repositories.Interfaces
{
    public interface IBookRepository : ICRUDRepository
    {
        Task<IEnumerable<Book>> GetAllBooks();
        Task<Book> GetBookById(string id);
        Task<IEnumerable<Book>> GetBookByName(string name);
        Task<IEnumerable<Book>> GetBooksByCategory(string categoryId);
        Task<IEnumerable<Book>> GetBooksByAuthor(string authorId);
        
    }
}
