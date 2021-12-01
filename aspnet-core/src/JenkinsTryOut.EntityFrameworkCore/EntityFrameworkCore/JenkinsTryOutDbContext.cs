using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using JenkinsTryOut.Authorization.Roles;
using JenkinsTryOut.Authorization.Users;
using JenkinsTryOut.MultiTenancy;

namespace JenkinsTryOut.EntityFrameworkCore
{
    public class JenkinsTryOutDbContext : AbpZeroDbContext<Tenant, Role, User, JenkinsTryOutDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public JenkinsTryOutDbContext(DbContextOptions<JenkinsTryOutDbContext> options)
            : base(options)
        {
        }
    }
}
