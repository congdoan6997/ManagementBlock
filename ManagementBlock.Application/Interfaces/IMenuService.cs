using ManagementBlock.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ManagementBlock.Application.Interfaces
{
    public interface IMenuService:IDisposable
    {
        Task<List<MenuViewModel>> GetAll();
        Task<List<MenuViewModel>> GetAllByPermission(Guid guid);

    }
}
