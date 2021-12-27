using BookWebApi.AppModels.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookWebApi.AppDataAccess.Repositories.Interfaces
{
    public interface IFavoriteBook :ICRUDRepository
    {
        Task<IEnumerable<AppUser>> BookFavoriteUsers(string bookId);
        Task<IEnumerable<Book>> GetFavoriteUserBooks(string userId);
    }
}
