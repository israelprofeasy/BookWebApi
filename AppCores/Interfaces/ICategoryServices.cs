using BookWebApi.AppModels.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookWebApi.AppCores.Interfaces
{
    public interface ICategoryServices
    {
        Task<CategoryReturnedDto> AddCategory(CategoryDto category);
        Task<bool> UpdateCategory(string categoryId, CategoryDto category);
        Task<List<CategoryReturnedDto>> GetAllCategory();
        Task<bool> DeleteCategory(string categoryId);
        Task<CategoryReturnedDto> GetCategoryById(string categoryId);
        Task<CategoryReturnedDto> GetCategoryByName(string categoryName);
    }
}
