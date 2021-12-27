using BookWebApi.AppModels.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookWebApi.AppDataAccess.Repositories.Interfaces
{
    public interface IAuthor : ICRUDRepository
    {
        Task<Author> GetAuthorById(string id);
        Task<IEnumerable<Author>> GetAuthors();
    }
}
