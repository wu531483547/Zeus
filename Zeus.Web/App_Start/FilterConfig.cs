﻿using System.Web.Mvc;

namespace Zeus.Web.App_Start
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandlerErrorAttribute());
        }
    }
}