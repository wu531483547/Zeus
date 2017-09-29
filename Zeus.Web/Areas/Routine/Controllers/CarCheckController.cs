using Ext.Net.MVC;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Zeus.Application.Routine;
using Zeus.Core;

namespace Zeus.Web.Areas.Routine.Controllers
{
    public class CarCheckController : ControllerBase
    {
        private CarCheckApp carcheckApp = new CarCheckApp();

        [HttpGet]
        [HandlerAjaxOnly]
        public StoreResult GetList(DateTime? BeginTime,DateTime? EndTime)
        {
            var data = carcheckApp.GetList(BeginTime, EndTime);
            return this.Store(data, data.Count);
        }

        [HttpPost]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult SaveSingle(string fpValue, string keyValue)
        {
            carcheckApp.SubmitSingle(JsonConvert.DeserializeObject<Dictionary<string, string>>(fpValue), keyValue);
            return Success("操作成功。");
        }

        [HttpPost]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteSingle(string keyValue)
        {
            carcheckApp.DeleteSingle(keyValue);
            return Success("操作成功。");
        }

        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetSingle(string keyValue)
        {
            var data = carcheckApp.GetSingle(keyValue);
            return Content(data.ToJson());
        }

        [HttpGet]
        public void CreateQrCode(string carNumber)
        {
            QrCode QC = new QrCode();
            QC.CreateCode_Choose("CG" + carNumber, "Byte", "L", 0, 4);
        }

        [HttpGet]
        public ActionResult Print()
        {
            return View();
        }
    }
}