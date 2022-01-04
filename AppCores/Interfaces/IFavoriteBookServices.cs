using BookWebApi.AppModels.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookWebApi.AppCores.Interfaces
{
    public interface IFavoriteBookServices
    {
        Task<bool> AddFavoriteBook(string userid, string bookid);
        Task<bool> RemoveFavoriteBook(string userid, string bookid);
        Task<List<BookFavoriteDto>> GetFavoriteBooks(string userId);
        Task<List<UserToReturnDto>> GetFavoritesUsers(string bookId);
        Task<List<UserListDto>> GetFavoritesUsersByCity(string city);
        Task<List<UserListDto>> GetFavoritesUsersByCountry(string country);
    }
}
