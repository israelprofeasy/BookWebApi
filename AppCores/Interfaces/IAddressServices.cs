using BookWebApi.AppModels.DTOs;
using BookWebApi.AppModels.Models;
using System.Threading.Tasks;

namespace BookWebApi.AppCores.Interfaces
{
    public interface IAddressServices
    {
        Task<bool> AddAdress(RegisterDto register, string userId);
        Task<bool> RemoveAdress(string userId);
        Task<bool> UpdateAdress(RegisterDto register, string userId);
        Task<AddressDto> GetAddress(string userId);
    }
}
