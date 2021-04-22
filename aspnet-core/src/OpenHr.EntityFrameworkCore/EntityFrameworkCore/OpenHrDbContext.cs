using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using OpenHr.Authorization.Roles;
using OpenHr.Authorization.Users;
using OpenHr.MultiTenancy;

namespace OpenHr.EntityFrameworkCore
{
    public class OpenHrDbContext : AbpZeroDbContext<Tenant, Role, User, OpenHrDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public OpenHrDbContext(DbContextOptions<OpenHrDbContext> options)
            : base(options)
        {
        }
    }
}
