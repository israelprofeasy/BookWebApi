using BookWebApi.AppCores.Interfaces;
using BookWebApi.AppModels.DTOs;
using System;
using System.Threading.Tasks;

namespace BookWebApi.AppCores.Implementations
{
    public class UploadServices : IUploadServices
    {
        public Task<Tuple<bool, UploadReturnedDto>> AddCvAsync(UploadReturnedDto model, string userId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeletePhotoAsync(string PublicId)
        {
            throw new NotImplementedException();
        }

        public Task<UploadReturnedDto> GetUserPhotosAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<Tuple<bool, UploadReturnedDto>> UploadCvAsync(UploadReturnedDto model, string userId)
        {
            throw new NotImplementedException();
        }
    }
}
