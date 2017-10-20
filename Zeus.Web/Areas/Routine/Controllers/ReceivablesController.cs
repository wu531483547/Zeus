using Ext.Net.MVC;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Zeus.Application.Routine;
using Zeus.Core;

namespace Zeus.Web.Areas.Routine.Controllers
{
    public class ReceivablesController : ControllerBase
    {
        private ReceivablesApp receivableApp = new ReceivablesApp();

        [HttpGet]
        [HandlerAjaxOnly]
        public StoreResult GetList(DateTime BeginTime, DateTime EndTime)
        {
            var data = receivableApp.GetList(BeginTime, EndTime);
            return this.Store(data, data.Count);
        }

        [HttpPost]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult SaveSingle(string fpValue, string keyValue)
        {
            receivableApp.SubmitSingle(JsonConvert.DeserializeObject<Dictionary<string, string>>(fpValue), keyValue);
            return Success("操作成功。");
        }

        [HttpPost]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteSingle(string keyValue)
        {
            receivableApp.DeleteSingle(keyValue);
            return Success("操作成功。");
        }

        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetSingle(string keyValue)
        {
            var data = receivableApp.GetSingle(keyValue);
            return Content(data.ToJson());
        }

        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetSumInfo(DateTime beginDate, DateTime endDate)
        {
            var data = receivableApp.GetSumInfo(beginDate,endDate);
            return Content(data.ToJson());
        }

        [HttpGet]
        public ActionResult Print()
        {
            return View();
        }
    }
}