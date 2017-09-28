using System.Web.Mvc;

namespace Zeus.Web.Areas.Routine
{
    public class RoutineAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Routine";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
              this.AreaName + "_Default",
              this.AreaName + "/{controller}/{action}/{id}",
              new { area = this.AreaName, controller = "Home", action = "Index", id = UrlParameter.Optional },
              new string[] { "Zeus.Web.Areas." + this.AreaName + ".Controllers" }
            );
        }
    }
}