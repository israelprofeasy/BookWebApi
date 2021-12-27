using BookWebApi.AppModels.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookWebApi.AppDataAccess.Repositories.Interfaces
{
    public interface ICategoryRepository : ICRUDRepository
    {
        Task<Category> GetCategoryById(string id);
        Task<Category> GetCategoryByName(string name);
        Task<IEnumerable<Category>> GetAllCategory();
    }
}
