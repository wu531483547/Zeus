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
        public StoreResult GetList(DateTime BeginTime,DateTime EndTime,string Take)
        {
            var data = carcheckApp.GetList(BeginTime, EndTime,Take);
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
            carcheckApp.CreateQrCode(data.F_1);
            return Content(data.ToJson());
        }        

        [HttpGet]
        public ActionResult Print()
        {
            return View();
        }

        #region 获取合计信息
        /// <summary>
        /// 获取合计信息
        /// </summary>
        /// <param name="beginDate">起始日期</param>
        /// <param name="endDate">截止日期</param>
        /// <returns></returns>
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetSumInfo(DateTime beginDate, DateTime endDate)
        {
            var data = carcheckApp.GetSumInfo(beginDate, endDate);
            return Content(data.ToJson());
        }
        #endregion
    }
}