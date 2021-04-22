using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace OpenHr.EntityFrameworkCore
{
    public static class OpenHrDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<OpenHrDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<OpenHrDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
