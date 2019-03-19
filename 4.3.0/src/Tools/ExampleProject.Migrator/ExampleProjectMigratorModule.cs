using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using ExampleProject.EntityFramework;

namespace ExampleProject.Migrator
{
    [DependsOn(typeof(ExampleProjectDataModule))]
    public class ExampleProjectMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<ExampleProjectDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}