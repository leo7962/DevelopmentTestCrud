using AutoMapper;
using DevelopmentTestCrud.Dtos;
using DevelopmentTestCrud.Models;

namespace DevelopmentTestCrud.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Customer, CustomerDto>().ReverseMap();
        }
    }
}
