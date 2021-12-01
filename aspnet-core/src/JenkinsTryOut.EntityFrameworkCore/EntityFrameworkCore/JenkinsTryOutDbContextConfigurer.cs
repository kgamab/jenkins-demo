using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace JenkinsTryOut.EntityFrameworkCore
{
    public static class JenkinsTryOutDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<JenkinsTryOutDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<JenkinsTryOutDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
