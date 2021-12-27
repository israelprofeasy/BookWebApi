using BookWebApi.AppModels.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookWebApi.AppDataAccess.Repositories.Interfaces
{
    public interface IUploadRepository : ICRUDRepository
    {
        Task<Upload> GetUpload(string bookId);
        Task<IEnumerable<Upload>> GetAllUploads();
    }
}
