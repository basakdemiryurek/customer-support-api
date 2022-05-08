using AutoMapper;
using CustomerSupportApi.Data.Entities;
using CustomerSupportApi.Models;

namespace CustomerSupportApi.Infrastructure.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateCustomerSupportFormRequest, CustomerSupportForm>();
        }
    }
}
