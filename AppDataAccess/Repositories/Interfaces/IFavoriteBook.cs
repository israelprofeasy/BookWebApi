using BookWebApi.AppModels.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookWebApi.AppDataAccess.Repositories.Interfaces
{
    public interface IFavoriteBook :ICRUDRepository
    {
        Task<IEnumerable<AppUser>> BookFavoriteUsers(string bookId);
        Task<IEnumerable<Book>> GetFavoriteUserBooks(string userId);
        Task<IEnumerable<AppUser>> GetFavoriteUserBooksByCity(string city);
        Task<IEnumerable<AppUser>> GetFavoriteUserBooksByCountry(string country);
        Task<FavouriteBook> GetFavouriteBook(string userId, string bookId);
    }
}
