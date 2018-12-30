using AutoMapper;
using ManagementBlock.Application.ViewModels;
using ManagementBlock.Data.Entities;

namespace ManagementBlock.Application.AutoMappers
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<ProductViewModel, Product>().ConstructUsing(c => new Product(c.Name, c.Description, c.Icon, c.Image, c.DateCreated, c.DateModified, c.Status));
        }
    }
}
