using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Zeus.Web.Controllers
{
    [HandlerLogin]
    public class HomeController : Controller
    {
        ///<summary>
        ///Author：Rex
        ///Description：系统首页
        ///CreateDate：2016-12-15
        ///</summary>
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Default()
        {
            return View();
        }
    }
}