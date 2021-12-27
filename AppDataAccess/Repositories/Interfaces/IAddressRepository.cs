using BookWebApi.AppModels.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookWebApi.AppDataAccess.Repositories.Interfaces
{
    public interface IAddressRepository : ICRUDRepository
    {
        Task<Address> GetAddress(string userId);
        Task<IEnumerable<Address>> GetAllAddress();
    }
}
