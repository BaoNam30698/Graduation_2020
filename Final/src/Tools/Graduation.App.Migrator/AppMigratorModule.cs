using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Graduation.App.EntityFramework;

namespace Graduation.App.Migrator
{
    [DependsOn(typeof(AppDataModule))]
    public class AppMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<AppDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}