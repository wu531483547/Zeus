﻿using Ext.Net.MVC;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Zeus.Application.Routine;

namespace Zeus.Web.Areas.Routine.Controllers
{
    public class DrugsDetailController : ControllerBase
    {
        private DrugsApp drugsApp = new DrugsApp();
        [HttpGet]
        [HandlerAjaxOnly]
        public StoreResult GetList(DateTime BeginTime, DateTime EndTime)
        {
            var data = drugsApp.GetList(BeginTime, EndTime);
            return this.Store(data, data.Count);
        }

        [HttpPost]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult SaveSingle(string fpValue, string keyValue)
        {
            drugsApp.SubmitSingle(JsonConvert.DeserializeObject<Dictionary<string, string>>(fpValue), keyValue);
            return Success("操作成功。");
        }

        [HttpPost]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteSingle(string keyValue)
        {
            drugsApp.DeleteSingle(keyValue);
            return Success("操作成功。");
        }
    }
}