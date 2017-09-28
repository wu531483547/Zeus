using Ext.Net;
using Ext.Net.MVC;
using System.Collections.Generic;
using System.Web.Mvc;
using Zeus.Application.Routine;
using Zeus.Model;

namespace Zeus.Web.Areas.Routine.Controllers
{
    public class JDCCYController : ControllerBase
    {
        private JdccyApp jdccyApp = new JdccyApp();

        [HttpGet]
        [HandlerAjaxOnly]
        public StoreResult GetList()
        {
            var data = jdccyApp.GetList();
            return this.Store(data, data.Count);
        }

        [HttpGet]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult SaveSingle(A_Jdccy jdccyEntity, string keyValue)
        {
            jdccyApp.SubmitSingle(jdccyEntity, keyValue);
            return Success("操作成功。");
        }

        [HttpGet]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteSingle(string keyValue)
        {
            jdccyApp.DeleteSingle(keyValue);
            return Success("操作成功。");
        }
    }
}