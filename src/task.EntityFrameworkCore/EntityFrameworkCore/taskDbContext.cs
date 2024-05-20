using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using task.Authorization.Roles;
using task.Authorization.Users;
using task.MultiTenancy;
using task.Entities;

namespace task.EntityFrameworkCore
{
    public class taskDbContext : AbpZeroDbContext<Tenant, Role, User, taskDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Todo> Todos { get; set; }
        public taskDbContext(DbContextOptions<taskDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure your entity here (if needed)
        }
    }
}
