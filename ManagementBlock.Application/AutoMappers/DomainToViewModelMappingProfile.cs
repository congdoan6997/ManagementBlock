using AutoMapper;
using ManagementBlock.Application.ViewModels;
using ManagementBlock.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManagementBlock.Application.AutoMappers
{
  public  class DomainToViewModelMappingProfile:Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Product, ProductViewModel>();
        }
    }
}
