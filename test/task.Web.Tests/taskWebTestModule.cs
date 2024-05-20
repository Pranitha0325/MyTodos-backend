using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using task.EntityFrameworkCore;
using task.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace task.Web.Tests
{
    [DependsOn(
        typeof(taskWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class taskWebTestModule : AbpModule
    {
        public taskWebTestModule(taskEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(taskWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(taskWebMvcModule).Assembly);
        }
    }
}