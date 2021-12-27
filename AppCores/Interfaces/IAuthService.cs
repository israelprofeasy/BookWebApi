using BookWebApi.AppModels.DTOs;
using System.Threading.Tasks;

namespace BookWebApi.AppCores.Interfaces
{
    public interface IAuthService
    {
        Task<LoginCredDto> Login(string email, string password, bool rememberMe);
    }
}
