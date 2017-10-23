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

        #region 获取明细列表
        /// <summary>
        /// 获取明细列表
        /// </summary>
        /// <param name="BeginTime">起始日期</param>
        /// <param name="EndTime">截止日期</param>
        /// <returns></returns>
        [HttpGet]
        [HandlerAjaxOnly]
        public StoreResult GetList(DateTime BeginTime, DateTime EndTime)
        {
            var data = receivableApp.GetList(BeginTime, EndTime);
            return this.Store(data, data.Count);
        }
        #endregion

        #region 保存明细
        /// <summary>
        /// 保存明细
        /// </summary>
        /// <param name="fpValue">明细</param>
        /// <param name="keyValue">主键</param>
        /// <returns></returns>
        [HttpPost]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult SaveSingle(string fpValue, string keyValue)
        {
            receivableApp.SubmitSingle(JsonConvert.DeserializeObject<Dictionary<string, string>>(fpValue), keyValue);
            return Success("操作成功。");
        }
        #endregion

        #region 删除明细
        /// <summary>
        /// 删除明细
        /// </summary>
        /// <param name="keyValue">主键</param>
        /// <returns></returns>
        [HttpPost]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteSingle(string keyValue)
        {
            receivableApp.DeleteSingle(keyValue);
            return Success("操作成功。");
        }
        #endregion

        #region 单条明细
        /// <summary>
        /// 单条明细
        /// </summary>
        /// <param name="keyValue">主键</param>
        /// <returns></returns>
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetSingle(string keyValue)
        {
            var data = receivableApp.GetSingle(keyValue);
            return Content(data.ToJson());
        }
        #endregion

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
            var data = receivableApp.GetSumInfo(beginDate, endDate);
            return Content(data.ToJson());
        }
        #endregion

        #region 明细打印页
        /// <summary>
        /// 明细打印页
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Print()
        {
            return View();
        }
        #endregion

        #region 记账还款
        /// <summary>
        /// 记账还款
        /// </summary>
        /// <param name="keyValue">主键</param>
        /// <returns></returns>
        [HttpPost]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult RepaymentRecord(string keyValue)
        {
            receivableApp.RepaymentRecord(keyValue);
            return Success("操作成功。");
        }
        #endregion

        #region 作废明细
        /// <summary>
        /// 作废明细
        /// </summary>
        /// <param name="keyValue">主键</param>
        /// <returns></returns>
        [HttpPost]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult InvalidRecord(string keyValue)
        {
            receivableApp.InvalidRecord(keyValue);
            return Success("操作成功。");
        }
        #endregion

        #region 恢复作废
        /// <summary>
        /// 恢复作废
        /// </summary>
        /// <param name="keyValue">主键</param>
        /// <returns></returns>
        [HttpPost]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        
        public ActionResult RecoveryInvalidRecord(string keyValue)
        {
            receivableApp.RecoveryInvalidRecord(keyValue);
            return Success("操作成功。");
        }
        #endregion
    }
}