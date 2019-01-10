using ManagementBlock.Data.Entities;
using ManagementBlock.Data.IRepositories;

namespace ManagementBlock.Data.EF.Repositories
{
    public class MenuRepository : EFRepository<Menu, string>, IMenuRepository
    {
        public MenuRepository(AppDbContext context) : base(context)
        {
        }
    }
}
