using AutoMapper;
using BookWebApi.AppModels.DTOs;
using BookWebApi.AppModels.Models;

namespace BookWebApi.AppCommons
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<RegisterDto, AppUser>()
               .ForMember(dest => dest.UserName, opt => opt.MapFrom(u => u.Email))
               .ForMember(dest => dest.Address, x => x.MapFrom(s => new Address
               {
                   City = s.City,
                   Country = s.Country
               }));
            CreateMap<AppUser, RegisterSuccessDto>()
               .ForMember(dest => dest.UserId, x => x.MapFrom(x => x.Id))
               .ForMember(d => d.FullName, x => x.MapFrom(x => $"{x.FirstName} {x.LastName}"));

            CreateMap<AppUser, UserToReturnDto>();
            CreateMap<RegisterDto, Address>();
            CreateMap<Author, AuthorDetailDto>();
            CreateMap<AuthorDto, Author>();
            CreateMap<Author, AuthorListDto>();
        }

       

    }
}
