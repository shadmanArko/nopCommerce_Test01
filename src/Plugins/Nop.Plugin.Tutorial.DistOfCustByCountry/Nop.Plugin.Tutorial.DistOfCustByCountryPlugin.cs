using Nop.Services.Cms;
using Nop.Services.Plugins;
using Nop.Web.Framework.Infrastructure;
using System.Collections.Generic;
using System.Threading.Tasks;
using Nop.Core;
using Nop.Plugin.Tutorial.DistOfCustByCountry.Controllers;
using Nop.Services.Common;
using Nop.Web.Framework.Menu;

namespace Nop.Plugin.Tutorial.DistOfCustByCountry
{
    /// <summary>
    /// Rename this file and change to the correct type
    /// </summary>
    public class CustomPlugin : BasePlugin
    {
        private readonly IWebHelper _webHelper;

        public CustomPlugin(IWebHelper webHelper)
        {
            _webHelper = webHelper;
        }

        public override string GetConfigurationPageUrl()
        {
            return $"{_webHelper.GetStoreLocation()}Admin/CustomersByCountry/GetCustomersCountByCountry";
        }
    }
}
