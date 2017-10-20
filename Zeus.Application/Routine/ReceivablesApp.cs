#region 版权说明
/*****************************************************************************
* Copyright (c) 2017 All Rights Reserved.
* CLR版本： 4.0.30319.42000 
*机器名称：DESKTOP-FUHBS8L
*公司名称：
*命名空间：Zeus.Application.Routine  
*文件名：  ReceivablesApp 
*版本号：  V1.0.0.0
*唯一标识：42827e46-fd99-4ee8-8e48-872855163644
*当前的用户域：DESKTOP-FUHBS8L
*创建人：  Rex
*创建时间：2017/10/20 8:58:53 

*描述：
*
*=====================================================================
*修改标记
*修改时间：2017/10/20 8:58:53 
*修改人： HY-REX 
*版本号： V1.0.0.0
*描述：
*
*****************************************************************************/
#endregion

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Zeus.Core;
using Zeus.IRepository.Routine;
using Zeus.Model;
using Zeus.Repository.Routine;

namespace Zeus.Application.Routine
{
    public class ReceivablesApp
    {
        private IReceivablesRepository service = new ReceivablesRepository();

        public List<A_Receivables> GetList(DateTime BeginTime, DateTime EndTime)
        {
            EndTime = EndTime.AddDays(1);
            return service.IQueryable().Where(t => DbFunctions.TruncateTime(t.F_CreatorTime) >= BeginTime
            && DbFunctions.TruncateTime(t.F_CreatorTime) <= EndTime).OrderBy(t => t.F_CreatorTime).ToList();
        }
        public A_Receivables GetSingle(string keyValue)
        {
            return service.FindEntity(keyValue);
        }
        public Dictionary<string,string> GetSumInfo(DateTime BeginTime, DateTime EndTime)
        {
            EndTime = EndTime.AddDays(1);
            var vList = new Dictionary<string,string>();
            var vEnableCount = service.IQueryable().Count(t => t.F_DeleteMark == null);
            var vDisableCount = service.IQueryable().Count(t => t.F_DeleteMark != null);
            var vSum = service.IQueryable().Where(t => t.F_DeleteMark == null).Sum(t => t.F_SFJE);
            vList.Add("vEnableCount", vEnableCount.ToString());
            vList.Add("vDisableCount", vDisableCount.ToString());
            vList.Add("vSum", vSum.ToString()); 
            return vList;
        }

        public void DeleteSingle(string keyValue)
        {
            service.Delete(t => t.F_Id == keyValue);
        }
        public void SubmitSingle(Dictionary<string, string> receivablesDic, string keyValue)
        {
            A_Receivables receivableEntity = new A_Receivables();
            receivableEntity.F_Id = keyValue;
            receivableEntity.F_SKDH = DateTime.Now.ToString("yyyyMMddHHmmss");
            if (receivablesDic.ContainsKey("F_CLLX"))
            {
                receivableEntity.F_CLLX = receivablesDic["F_CLLX"].Trim();
            }
            if (receivablesDic.ContainsKey("F_CLLB"))
            {
                receivableEntity.F_CLLB = receivablesDic["F_CLLB"].Trim();
            }
            receivableEntity.F_MH = receivablesDic.ContainsKey("F_MH") == true ? true : false;
            receivableEntity.F_MZ = receivablesDic.ContainsKey("F_MZ") == true ? true : false;
            receivableEntity.F_ZX = receivablesDic.ContainsKey("F_ZX") == true ? true : false;
            receivableEntity.F_ZZL = receivablesDic.ContainsKey("F_ZZL") == true ? true : false;
            receivableEntity.F_KDH = receivablesDic.ContainsKey("F_KDH") == true ? true : false;
            receivableEntity.F_RS = receivablesDic.ContainsKey("F_RS") == true ? true : false;
            if (receivablesDic.ContainsKey("F_SFJE"))
            {
                receivableEntity.F_SFJE = receivablesDic["F_SFJE"].Trim().ToDecimal();
            }
            if (receivablesDic.ContainsKey("F_JEDX"))
            {
                receivableEntity.F_JEDX = receivablesDic["F_JEDX"].Trim();
            }
            receivableEntity.F_SKRY = OperatorProvider.Provider.GetCurrent().UserId;
            if (receivablesDic.ContainsKey("F_JKRY"))
            {
                receivableEntity.F_JKRY = receivablesDic["F_JKRY"].Trim();
            }
            receivableEntity.F_JZZT = receivablesDic.ContainsKey("F_JZZT") == true ? true : false;
            receivableEntity.F_ZFZT = receivablesDic.ContainsKey("F_ZFZT") == true ? false : true;
            if (receivablesDic.ContainsKey("F_Remakes"))
            {
                receivableEntity.F_Remakes = receivablesDic["F_Remakes"].Trim();
            }
            if (!string.IsNullOrEmpty(keyValue))
            {
                receivableEntity.Modify(keyValue);
                service.Update(receivableEntity);
            }
            else
            {
                receivableEntity.Create();
                service.Insert(receivableEntity);
            }
        }
    }
}
