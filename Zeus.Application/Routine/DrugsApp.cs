#region 版权说明
/*****************************************************************************
* Copyright (c) 2017 All Rights Reserved.
* CLR版本： 4.0.30319.42000 
*机器名称：DESKTOP-FUHBS8L
*公司名称：
*命名空间：Zeus.Application.Routine  
*文件名：  DrugsApp 
*版本号：  V1.0.0.0
*唯一标识：63cc29e8-aac7-4ecf-a6c1-422bcf06a891
*当前的用户域：DESKTOP-FUHBS8L
*创建人：  Rex
*创建时间：2017/12/15 9:53:18 

*描述：
*
*=====================================================================
*修改标记
*修改时间：2017/12/15 9:53:18 
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
    public class DrugsApp
    {
        private IDrugsRepository service = new DrugsRepository();

        public List<A_Drugs> GetList(DateTime BeginTime, DateTime EndTime)
        {
            EndTime = EndTime.AddDays(1);
            return service.IQueryable().Where(t => DbFunctions.TruncateTime(t.F_CreatorTime) >= BeginTime
            && DbFunctions.TruncateTime(t.F_CreatorTime) <= EndTime).OrderByDescending(t => t.F_CreatorTime).ToList();
        }

        public A_Drugs GetSingle(string keyValue)
        {
            return service.FindEntity(keyValue);
        }

        public void DeleteSingle(string keyValue)
        {
            service.Delete(t => t.F_Id == keyValue);
        }

        public void SubmitSingle(Dictionary<string, string> carcheckDic, string keyValue)
        {
            A_Drugs drugsEntity = new A_Drugs();
            drugsEntity.F_Id = keyValue;
            if (carcheckDic.ContainsKey("F_1"))
            {
                drugsEntity.F_1 = carcheckDic["F_1"].Trim();
            }
            if (carcheckDic.ContainsKey("F_2"))
            {
                drugsEntity.F_2 = carcheckDic["F_2"].Trim();
            }
            if (carcheckDic.ContainsKey("F_3"))
            {
                drugsEntity.F_3 = carcheckDic["F_3"].Trim();
            }
            if (carcheckDic.ContainsKey("F_4"))
            {
                drugsEntity.F_4 = carcheckDic["F_4"].Trim();
            }             
            if (carcheckDic.ContainsKey("F_Remakes"))
            {
                drugsEntity.F_Remakes = carcheckDic["F_Remakes"].Trim();
            }
            if (!string.IsNullOrEmpty(keyValue))
            {
                drugsEntity.Modify(keyValue);
                service.Update(drugsEntity);
            }
            else
            {
                drugsEntity.Create();
                service.Insert(drugsEntity);
            }
        }
    }
}
