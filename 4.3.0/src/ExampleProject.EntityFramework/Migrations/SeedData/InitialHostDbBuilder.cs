using ExampleProject.EntityFramework;
using EntityFramework.DynamicFilters;

namespace ExampleProject.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly ExampleProjectDbContext _context;

        public InitialHostDbBuilder(ExampleProjectDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
