using BookWebApi.AppModels.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookWebApi.AppCores.Interfaces
{
    public interface IAuthorServices
    {
        Task<AuthorDetailDto> AddAuthor(AuthorDto author);
        Task<bool> UpdateAuthor(string authorid, AuthorDto author);
        Task<List<AuthorListDto>> GetAllAuthorList();
        Task<AuthorDetailDto> GetAuthorById(string id);
        Task<bool> DeleteAuthor(string id);
    }
}
