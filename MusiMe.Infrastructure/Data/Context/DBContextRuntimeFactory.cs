using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace MusiMe.Infrastructure.Data.Context
{
    public class DBContextRuntimeFactory : IDesignTimeDbContextFactory<DBContext>
    {
        public DBContext CreateDbContext(string[] args)
        {
            string basePath = Directory.GetCurrentDirectory();
            var confi = new ConfigurationBuilder()
                .SetBasePath(basePath)
                .AddJsonFile("appsettings.json", optional: false)
                .Build();
            string connectionString = confi.GetConnectionString("ConnectionString") ?? String.Empty;

            var OptionBuilder = new DbContextOptionsBuilder<DBContext>();
            OptionBuilder.UseNpgsql(connectionString);

            return new DBContext(OptionBuilder.Options);
        }
    }
}
