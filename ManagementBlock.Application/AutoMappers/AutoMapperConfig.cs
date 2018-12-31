using AutoMapper;

namespace ManagementBlock.Application.AutoMappers
{
    public class AutoMapperConfig
    {
        public static MapperConfiguration RegisterMapper()
        {
            
            return new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new DomainToViewModelMappingProfile());
                cfg.AddProfile(new ViewModelToDomainMappingProfile());
            });
        }
    }
}
