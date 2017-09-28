using Ext.Net;
using Ext.Net.MVC;
using System.Collections.Generic;
using System.Web.Mvc;
using Zeus.Application.Routine;
using Zeus.Model;

namespace Zeus.Web.Areas.Routine.Controllers
{
    public class CarCheckController : ControllerBase
    {
        private CarCheckApp carcheckApp = new CarCheckApp();

        [HttpGet]
        [HandlerAjaxOnly]
        public StoreResult GetList()
        {
            var data = carcheckApp.GetList();
            return this.Store(data, data.Count);
        }

        [HttpPost]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult SaveSingle(A_CarCheck fpValue, string keyValue)
        {
            //carcheckApp.SubmitSingle(carcheckEntity, keyValue);
            return Success("操作成功。");
            //return DirectNotify();
        }

        [HttpGet]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteSingle(string keyValue)
        {
            carcheckApp.DeleteSingle(keyValue);
            return Success("操作成功。");
        }
    }
}