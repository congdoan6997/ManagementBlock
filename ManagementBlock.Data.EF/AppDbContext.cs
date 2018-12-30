using ManagementBlock.Data.Entities;
using ManagementBlock.Data.Interfaces;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ManagementBlock.Data.EF
{
    public class AppDbContext : IdentityDbContext<AppUser, AppRole, Guid>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Bill> Bills { get; set; }

        public DbSet<AppUser> AppUsers { get; set; }

        public DbSet<AppRole> AppRoles { get; set; }

        public DbSet<Menu> Menus { get; set; }

        public DbSet<Slide> Slides { get; set; }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {


            base.OnModelCreating(builder);
        }

        public override int SaveChanges()
        {
            var modified = ChangeTracker.Entries().Where(e => e.State == EntityState.Modified || e.State == EntityState.Added);
            foreach (var item in modified)
            {
                if (item.Entity is IDateTracking changeOrAddItem)
                {
                    if (item.State == EntityState.Added)
                    {
                        changeOrAddItem.DateCreated = DateTime.Now;
                    }
                    changeOrAddItem.DateModified = DateTime.Now;
                }

            }
            return base.SaveChanges();
        }
        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default(CancellationToken))
        {
            var modified = ChangeTracker.Entries().Where(e => e.State == EntityState.Modified || e.State == EntityState.Added);
            foreach (var item in modified)
            {
                if (item.Entity is IDateTracking changeOrAddItem)
                {
                    if (item.State == EntityState.Added)
                    {
                        changeOrAddItem.DateCreated = DateTime.Now;
                    }
                    changeOrAddItem.DateModified = DateTime.Now;
                }

            }
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }
    }
}
