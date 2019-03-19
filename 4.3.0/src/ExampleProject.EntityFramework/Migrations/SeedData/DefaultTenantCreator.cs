using System.Linq;
using ExampleProject.EntityFramework;
using ExampleProject.MultiTenancy;

namespace ExampleProject.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly ExampleProjectDbContext _context;

        public DefaultTenantCreator(ExampleProjectDbContext context)
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
