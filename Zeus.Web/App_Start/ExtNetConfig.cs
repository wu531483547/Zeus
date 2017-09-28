using System.Web.Mvc;
using System.Web.Routing;
 
[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(Zeus.Web.ExtNetConfig), "Start")]

namespace Zeus.Web 
{
    public static class ExtNetConfig 
    {
        public static void Start() 
        {
            ExtNetConfig.RegisterRoutes(RouteTable.Routes);
        }
 
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{extnet-root}/{extnet-file}/ext.axd");
            routes.MapRoute(
                "ExtNet",
                "extnet/{action}/{id}",
                new { controller = "ExtNet", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}