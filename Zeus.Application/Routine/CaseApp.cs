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
    public class CaseApp
    {
        private ICaseRepository service = new CaseRepository();

        public List<A_Case> GetList(DateTime BeginTime, DateTime EndTime,string PatientName)
        {
            if (!string.IsNullOrEmpty(PatientName))
            {
                return service.IQueryable().Where(t => t.F_2 == PatientName).OrderByDescending(t => t.F_CreatorTime).ToList();
            }
            else
            {
                EndTime = EndTime.AddDays(1);
                return service.IQueryable().Where(t => DbFunctions.TruncateTime(t.F_CreatorTime) >= BeginTime
                && DbFunctions.TruncateTime(t.F_CreatorTime) <= EndTime).OrderByDescending(t => t.F_CreatorTime).ToList();
            }            
        }

        public A_Case GetSingle(string keyValue)
        {
            return service.FindEntity(keyValue);
        }

        public void DeleteSingle(string keyValue)
        {
            service.Delete(t => t.F_Id == keyValue);
        }

        public void SubmitSingle(Dictionary<string, string> carcheckDic, string keyValue)
        {
            A_Case caseEntity = new A_Case();
            caseEntity.F_Id = keyValue;
            if (carcheckDic.ContainsKey("F_2"))
            {
                caseEntity.F_2 = carcheckDic["F_2"].Trim();
            }
            if (carcheckDic.ContainsKey("F_3"))
            {
                caseEntity.F_3 = carcheckDic["F_3"].Trim();
            }
            if (carcheckDic.ContainsKey("F_4"))
            {
                caseEntity.F_4 = carcheckDic["F_4"].Trim();
            }
            if (carcheckDic.ContainsKey("F_5"))
            {
                caseEntity.F_5 = carcheckDic["F_5"].Trim();
            }

            if (carcheckDic.ContainsKey("F_6"))
            {
                caseEntity.F_6 = carcheckDic["F_6"].Trim();
            }

            if (carcheckDic.ContainsKey("F_7"))
            {
                caseEntity.F_7 = carcheckDic["F_7"].Trim();
            }

            if (carcheckDic.ContainsKey("F_8"))
            {
                caseEntity.F_8 = carcheckDic["F_8"].Trim();
            }

            if (carcheckDic.ContainsKey("F_9"))
            {
                caseEntity.F_9 = carcheckDic["F_9"].Trim();
            }
            if (carcheckDic.ContainsKey("F_10"))
            {
                caseEntity.F_10 = carcheckDic["F_10"].Trim();
            }
            if (carcheckDic.ContainsKey("F_Remakes"))
            {
                caseEntity.F_Remakes = carcheckDic["F_Remakes"].Trim();
            }
            if (!string.IsNullOrEmpty(keyValue))
            {
                caseEntity.Modify(keyValue);
                service.Update(caseEntity);
            }
            else
            {
                caseEntity.F_1 = DateTime.Now.ToString("yyyyMMddHHmmss");
                caseEntity.Create();
                service.Insert(caseEntity);
            }
        }
    }
}
