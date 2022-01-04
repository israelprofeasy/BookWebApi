using AutoMapper;
using BookWebApi.AppCores.Interfaces;
using BookWebApi.AppDataAccess.Repositories.Interfaces;
using BookWebApi.AppModels.DTOs;
using BookWebApi.AppModels.Models;
using System;
using System.Threading.Tasks;

namespace BookWebApi.AppCores.Implementations
{
    public class AddressServices : IAddressServices
    {
        private readonly IAddressRepository _addressRepo;
        private readonly IMapper _mapper;

        public AddressServices(IAddressRepository addressRepository, IMapper mapper)
        {
            _addressRepo = addressRepository;
            _mapper = mapper;
        }
        public async Task<bool> AddAdress(RegisterDto register, string userId)
        {
            var res = _mapper.Map<Address>(register);
            res.AppUserId = userId;
            try
            {
                var addAddress = await _addressRepo.Add(register);
                if (addAddress)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return false;
        }

        public async  Task<AddressDto> GetAddress(string userId)
        {
            try
            {

                var res = await _addressRepo.GetAddress(userId);
                if (res != null)
                {
                    var address = _mapper.Map<AddressDto>(res);
                    return address;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
                return null;
        }

        public async Task<bool> RemoveAdress(string userId)
        {
            var address = await _addressRepo.GetAddress(userId);
            try
            {
                var res = await _addressRepo.Delete(address);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return false;
        }

        public async Task<bool> UpdateAdress(RegisterDto register, string userId)
        {
            try
            {
                var address = _mapper.Map<Address>(register);
                address.AppUserId = userId;
                var res = await _addressRepo.Update(address);
                return res;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
           // return false;
        }
    }
}
