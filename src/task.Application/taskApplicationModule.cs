﻿using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using task.Authorization;

namespace task
{
    [DependsOn(
        typeof(taskCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class taskApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<taskAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(taskApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
