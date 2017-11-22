using System.Reflection;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using Calabonga.Configurations;

namespace Calabonga.ConfigurationDemo.Infrastructure
{
    /// <summary>
    /// Autofac container configuration
    /// </summary>
    public static class DependencyContainer
    {
        public static void Initialize()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(Assembly.GetExecutingAssembly());

            // Calabonga.Configuration injections
            builder.RegisterType<CacheService>().As<ICacheService>();
            builder.RegisterType<JsonConfigSerializer>().As<IConfigSerializer>();
            builder.RegisterType<ProductionSettingsManager>().Keyed<ISettingsManager>("PRODUCTION");
            builder.RegisterType<LocalSettingsManager>().Keyed<ISettingsManager>("LOCAL");

            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}