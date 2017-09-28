using System;
using System.Web.Mvc;

namespace Zeus.Web
{
    [AttributeUsage(AttributeTargets.Method)]

    #region 只允许Ajax调用
    /// <summary>
    /// 只允许Ajax调用
    /// </summary>
    public class HandlerAjaxOnlyAttribute : ActionMethodSelectorAttribute
    {
        public bool Ignore { get; set; }


        public HandlerAjaxOnlyAttribute(bool ignore = false)
        {
            Ignore = ignore;
        }
        public override bool IsValidForRequest(ControllerContext controllerContext, System.Reflection.MethodInfo methodInfo)
        {
            if (Ignore)
                return true;
            return controllerContext.RequestContext.HttpContext.Request.IsAjaxRequest();
        }
    }
    #endregion
}
