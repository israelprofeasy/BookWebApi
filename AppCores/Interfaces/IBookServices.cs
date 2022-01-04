using BookWebApi.AppModels.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookWebApi.AppCores.Interfaces
{
    public interface IBookServices
    {
        Task<BookFavoriteDto> AddBook(BookDetailDto bookDetailDto);
        Task<bool> RemoveBook(string bookId);
        //Task<BookReturnedDto> UpdateBook(BookDetailDto bookDetailDto);
        Task<List<BookReturnedDto>> GetAllBook();
        Task<BookReturnedDto> GetBook(string bookId);
        Task<BookReturnedDto> GetBookByISBN(string ISBN);
        Task<List<BookReturnedDto>> GetBooksByName(string name);
        Task<List<BookReturnedDto>> GetBooksByCategory(string categoryId);



    }
}
