using AutoMapper.QueryableExtensions;
using ManagementBlock.Application.Interfaces;
using ManagementBlock.Application.ViewModels;
using ManagementBlock.Data.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ManagementBlock.Application.Implementation
{
    public class MenuService : IMenuService
    {
        private readonly IMenuRepository _menuRepository;

        public MenuService(IMenuRepository menuRepository)
        {
            _menuRepository = menuRepository;

        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public Task<List<MenuViewModel>> GetAll()
        {
            return _menuRepository.FindAll().ProjectTo<MenuViewModel>().ToListAsync();
        }

        public Task<List<MenuViewModel>> GetAllByPermission(Guid guid)
        {
            throw new NotImplementedException();
        }
    }
}
