using BookWebApi.AppModels.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookWebApi.AppCores.Interfaces
{
    public interface IBook_AuthorServices
    {
        Task<bool> AddBookAuthor(string authorId, string bookId);
        Task<bool> RemoveBookAuthor(string authorId, string bookId);
        Task<List<BookFavoriteDto>> GetAuthorBooks(string authorId);
        Task<List<AuthorListDto>> GetBookAuthors(string bookId);
    }
}
