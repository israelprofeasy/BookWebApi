using BookWebApi.AppCores.Interfaces;
using BookWebApi.AppModels.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookWebApi.AppCores.Implementations
{
    public class FavoriteBookService : IFavoriteBookServices
    {
        public Task<bool> AddFavoriteBook(string userid, string bookid)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<BookFavoriteDto>> GetFavoriteBooks(string userId)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<UserToReturnDto>> GetFavoritesUsers(string bookId)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<UserListDto>> GetFavoritesUsersByCity(string city)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<UserListDto>> GetFavoritesUsersByCountry(string country)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> RemoveFavoriteBook(string userid, string bookid)
        {
            throw new System.NotImplementedException();
        }
    }
}
