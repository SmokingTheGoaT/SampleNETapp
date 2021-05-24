using AutoMapper;
using SampleNETapp.Domain.Models;
using SampleNETapp.Resources;

namespace SampleNETapp.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<SaveCategoryResource, Category>();
        }
    }
}