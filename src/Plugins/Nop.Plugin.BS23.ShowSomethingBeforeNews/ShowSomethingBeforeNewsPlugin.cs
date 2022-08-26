using Nop.Services.Cms;
using Nop.Services.Plugins;
using Nop.Web.Framework.Infrastructure;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Nop.Plugin.BS23.ShowSomethingBeforeNews
{
    /// <summary>
    /// Rename this file and change to the correct type
    /// </summary>
    public class ShowSomethingBeforeNewsPlugin : BasePlugin, IWidgetPlugin
    {
        public bool HideInWidgetList => false;


        public override Task InstallAsync()
        {
            return base.InstallAsync();
        }

        public override Task UninstallAsync()
        {
            return base.UninstallAsync();
        }
        
        public Task<IList<string>> GetWidgetZonesAsync()
        {
            return Task.FromResult<IList<string>>(new List<string> { PublicWidgetZones.HomepageBeforeNews });
        }

        public string GetWidgetViewComponentName(string widgetZone)
        {
            return "ShowSomething";
        }
    }
}
