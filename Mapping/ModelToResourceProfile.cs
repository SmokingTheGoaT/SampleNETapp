using AutoMapper;
using SampleNETapp.Domain.Models;
using SampleNETapp.Resources;

namespace SampleNETapp.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Category, CategoryResource>();
        }
    }
}