using BookWebApi.AppCores.Interfaces;
using BookWebApi.AppModels.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookWebApi.AppCores.Implementations
{
    public class CategoryServices : ICategoryServices
    {
        public Task<CategoryReturnedDto> AddCategory(CategoryDto category)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> DeleteCategory(string categoryId)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<CategoryReturnedDto>> GetAllCategory()
        {
            throw new System.NotImplementedException();
        }

        public Task<CategoryReturnedDto> GetCategoryById(string categoryId)
        {
            throw new System.NotImplementedException();
        }

        public Task<CategoryReturnedDto> GetCategoryByName(string categoryName)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> UpdateCategory(string categoryId, CategoryDto category)
        {
            throw new System.NotImplementedException();
        }
    }
}
