using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using OpenHr.Configuration;
using OpenHr.Web;

namespace OpenHr.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class OpenHrDbContextFactory : IDesignTimeDbContextFactory<OpenHrDbContext>
    {
        public OpenHrDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<OpenHrDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            OpenHrDbContextConfigurer.Configure(builder, configuration.GetConnectionString(OpenHrConsts.ConnectionStringName));

            return new OpenHrDbContext(builder.Options);
        }
    }
}
