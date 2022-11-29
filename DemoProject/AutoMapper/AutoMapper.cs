using AutoMapper;
using DemoProject.Models;

namespace DemoProject.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<AccountDTO, Account>().ReverseMap()
                .ForMember(dest=> dest.OwnerName, opt => opt.MapFrom(x=>x.Owner.Name)); 

            CreateMap<AccountDetailsDTO, Account>().ReverseMap()
                .ForMember(dest => dest.OwnerName, opt => opt.MapFrom(x => x.Owner.Name)); 
        }
    }

}
