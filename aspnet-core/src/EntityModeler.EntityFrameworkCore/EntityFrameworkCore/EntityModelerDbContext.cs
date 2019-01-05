using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using EntityModeler.Authorization.Roles;
using EntityModeler.Authorization.Users;
using EntityModeler.MultiTenancy;

namespace EntityModeler.EntityFrameworkCore
{
    public class EntityModelerDbContext : AbpZeroDbContext<Tenant, Role, User, EntityModelerDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public EntityModelerDbContext(DbContextOptions<EntityModelerDbContext> options)
            : base(options)
        {
        }
    }
}
