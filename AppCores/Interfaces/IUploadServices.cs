using BookWebApi.AppModels.DTOs;
using System;
using System.Threading.Tasks;

namespace BookWebApi.AppCores.Interfaces
{
    public interface IUploadServices
    {
        public Task<Tuple<bool, UploadReturnedDto>> UploadCvAsync(UploadReturnedDto model, string userId);
        public Task<Tuple<bool, UploadReturnedDto>> AddCvAsync(UploadReturnedDto model, string userId);
        public Task<UploadReturnedDto> GetUserPhotosAsync(string userId);
        public Task<bool> DeletePhotoAsync(string PublicId);
    }
}
