using System.Linq;
using Graduation.App.EntityFramework;
using Graduation.App.MultiTenancy;

namespace Graduation.App.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly AppDbContext _context;

        public DefaultTenantCreator(AppDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
