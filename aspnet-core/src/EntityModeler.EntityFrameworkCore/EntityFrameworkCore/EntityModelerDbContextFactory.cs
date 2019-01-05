using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using EntityModeler.Configuration;
using EntityModeler.Web;

namespace EntityModeler.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class EntityModelerDbContextFactory : IDesignTimeDbContextFactory<EntityModelerDbContext>
    {
        public EntityModelerDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<EntityModelerDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            EntityModelerDbContextConfigurer.Configure(builder, configuration.GetConnectionString(EntityModelerConsts.ConnectionStringName));

            return new EntityModelerDbContext(builder.Options);
        }
    }
}
