using System;
using System.Web;
using Calabonga.Configurations;

namespace Calabonga.ConfigurationDemo.Infrastructure
{
    /// <summary>
    /// Configuration manager
    /// </summary>
    public class ProductionSettingsManager : Configuration<ApplicationSettings>, ISettingsManager
    {
        public ProductionSettingsManager(IConfigSerializer serializer, ICacheService cacheService)
            : base(serializer, cacheService)
        {
        }

        public override string DirectoryName
        {
            get { return HttpContext.Current.Server.MapPath("~/Configurations"); }
        }

        public override string FileName
        {
            get { return "appsettings.production.json"; }
        }
    }

    /// <summary>
    /// Configuration manager
    /// </summary>
    public class LocalSettingsManager : Configuration<ApplicationSettings>, ISettingsManager
    {
        public LocalSettingsManager(IConfigSerializer serializer, ICacheService cacheService)
            : base(serializer, cacheService)
        {
        }

        public override string DirectoryName
        {
            get { return HttpContext.Current.Server.MapPath("~/Configurations"); }
        }

        public override string FileName
        {

            get { return "appsettings.local.json"; }
        }
    }
}
