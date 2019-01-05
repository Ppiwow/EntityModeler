using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace EntityModeler.EntityFrameworkCore
{
    public static class EntityModelerDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<EntityModelerDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<EntityModelerDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
