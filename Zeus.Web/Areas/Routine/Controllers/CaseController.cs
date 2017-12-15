using Ext.Net.MVC;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Zeus.Application.Routine;

namespace Zeus.Web.Areas.Routine.Controllers
{
    public class CaseController : ControllerBase
    {
        private CaseApp caseApp = new CaseApp();
        [HttpGet]
        [HandlerAjaxOnly]
        public StoreResult GetList(DateTime BeginTime, DateTime EndTime,string PatientName)
        {
            var data = caseApp.GetList(BeginTime, EndTime, PatientName);
            return this.Store(data, data.Count);
        }

        [HttpPost]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult SaveSingle(string fpValue, string keyValue)
        {
            caseApp.SubmitSingle(JsonConvert.DeserializeObject<Dictionary<string, string>>(fpValue), keyValue);
            return Success("操作成功。");
        }

        [HttpPost]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteSingle(string keyValue)
        {
            caseApp.DeleteSingle(keyValue);
            return Success("操作成功。");
        }
    }
}