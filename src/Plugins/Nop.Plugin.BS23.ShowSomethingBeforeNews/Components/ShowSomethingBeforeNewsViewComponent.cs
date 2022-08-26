using System;
using Microsoft.AspNetCore.Mvc;
using Nop.Web.Framework.Components;

namespace Nop.Plugin.BS23.ShowSomethingBeforeNews.Components;

[ViewComponent(Name = "ShowSomething")]
public class ShowSomethingBeforeNewsViewComponent : NopViewComponent
{
    public IViewComponentResult Invoke(string widgetZone, object additionalData)
    {
        return Content("Hello World");
    }
}