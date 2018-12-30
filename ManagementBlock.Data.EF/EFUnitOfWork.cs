using ManagementBlock.Infrastructure.Interfaces;

namespace ManagementBlock.Data.EF
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        public EFUnitOfWork(AppDbContext dbContext)
        {
            this._context = dbContext;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            this._context.Dispose();
        }
    }
}
