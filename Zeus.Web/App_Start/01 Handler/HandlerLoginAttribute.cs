using Zeus.Core;
using System.Web.Mvc;

namespace Zeus.Web
{
    public class HandlerLoginAttribute : AuthorizeAttribute
    {
        public bool Ignore = true;
        public HandlerLoginAttribute(bool ignore = true)
        {
            Ignore = ignore;
        }
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            if (Ignore == false)
            {
                return;
            }
            if (OperatorProvider.Provider.GetCurrent() == null)
            {
                WebHelper.WriteCookie("Ares_login_error", "overdue");
                //filterContext.HttpContext.Response.Write("<script>top.location.href = '/Login/Index';</script>");
                filterContext.HttpContext.Response.Redirect("/Login/Index");
                return;
            }
        }
    }
}