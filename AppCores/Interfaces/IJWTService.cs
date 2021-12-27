using BookWebApi.AppModels.Models;
using System.Collections.Generic;

namespace BookWebApi.AppCores.Interfaces
{
    public interface IJWTService
    {
        string GenerateToken(AppUser user, List<string> userRoles);
    }
}
