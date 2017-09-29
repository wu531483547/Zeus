#region 版权说明
/*****************************************************************************
* Copyright (c) 2017 All Rights Reserved.
* CLR版本： 4.0.30319.42000 
*机器名称：DESKTOP-FUHBS8L
*公司名称：
*命名空间：Zeus.Application.Routine  
*文件名：  JdccyApp 
*版本号：  V1.0.0.0
*唯一标识：c626ce4b-414b-40b0-b43d-c3ba8c6f3d86
*当前的用户域：DESKTOP-FUHBS8L
*创建人：  Rex
*创建时间：2017/9/26 8:50:32 

*描述：
*
*=====================================================================
*修改标记
*修改时间：2017/9/26 8:50:32 
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
using System.Web;
using Zeus.Core;
using Zeus.IRepository.Routine;
using Zeus.Model;
using Zeus.Repository.Routine;

namespace Zeus.Application.Routine
{
    public class CarCheckApp
    {
        private ICarCheckRepository service = new CarCheckRepository();

        public List<A_CarCheck> GetList(DateTime? BeginTime, DateTime? EndTime)
        {
            return service.IQueryable().Where(t => DbFunctions.TruncateTime(t.F_CreatorTime)>= BeginTime
            && DbFunctions.TruncateTime(t.F_CreatorTime) <= BeginTime
            ).OrderBy(t => t.F_CreatorTime).ToList();
        }
        public A_CarCheck GetSingle(string keyValue)
        {
            return service.FindEntity(keyValue);
        }
        public void DeleteSingle(string keyValue)
        {
            service.Delete(t => t.F_Id == keyValue);
        }
        public void SubmitSingle(Dictionary<string, string> carcheckDic, string keyValue)
        {
            A_CarCheck carcheckEntity = new A_CarCheck();
            carcheckEntity.F_Id = keyValue;
            if (carcheckDic.ContainsKey("F_1"))
            {
                carcheckEntity.F_1 = carcheckDic["F_1"].Trim();
            }
            if (carcheckDic.ContainsKey("F_2"))
            {
                carcheckEntity.F_2 = carcheckDic["F_2"].Trim();
            }
            if (carcheckDic.ContainsKey("F_3"))
            {
                carcheckEntity.F_3 = carcheckDic["F_3"].Trim();
            }
            if (carcheckDic.ContainsKey("F_4"))
            {
                carcheckEntity.F_4 = carcheckDic["F_4"].Trim();
            }
            if (carcheckDic.ContainsKey("F_5"))
            {
                carcheckEntity.F_5 = carcheckDic["F_5"].Trim();
            }
            if (carcheckDic.ContainsKey("F_6"))
            {
                carcheckEntity.F_6 = true;
            }
            if (carcheckDic.ContainsKey("F_7"))
            {
                carcheckEntity.F_7 = true;
            }
            if (carcheckDic.ContainsKey("F_8"))
            {
                carcheckEntity.F_8 = true;
            }
            if (carcheckDic.ContainsKey("F_9"))
            {
                carcheckEntity.F_9 = true;
            }
            if (carcheckDic.ContainsKey("F_10"))
            {
                carcheckEntity.F_10 = true;
            }
            if (carcheckDic.ContainsKey("F_11"))
            {
                carcheckEntity.F_11 = true;
            }
            if (carcheckDic.ContainsKey("F_12"))
            {
                carcheckEntity.F_12 = true;
            }
            if (carcheckDic.ContainsKey("F_13"))
            {
                carcheckEntity.F_13 = true;
            }
            if (carcheckDic.ContainsKey("F_14"))
            {
                carcheckEntity.F_14 = true;
            }
            if (carcheckDic.ContainsKey("F_15"))
            {
                carcheckEntity.F_15 = true;
            }
            if (carcheckDic.ContainsKey("F_16"))
            {
                carcheckEntity.F_16 = true;
            }
            if (carcheckDic.ContainsKey("F_17"))
            {
                carcheckEntity.F_17 = true;
            }
            if (carcheckDic.ContainsKey("F_18"))
            {
                carcheckEntity.F_18 = true;
            }
            if (carcheckDic.ContainsKey("F_19"))
            {
                carcheckEntity.F_19 = true;
            }
            if (carcheckDic.ContainsKey("F_20"))
            {
                carcheckEntity.F_20 = true;
            }
            if (carcheckDic.ContainsKey("F_21"))
            {
                carcheckEntity.F_21 = true;
            }
            if (carcheckDic.ContainsKey("F_22"))
            {
                carcheckEntity.F_22 = true;
            }
            if (carcheckDic.ContainsKey("F_23"))
            {
                carcheckEntity.F_23 = true;
            }
            if (carcheckDic.ContainsKey("F_24"))
            {
                carcheckEntity.F_24 = true;
            }
            if (carcheckDic.ContainsKey("F_25"))
            {
                carcheckEntity.F_25 = true;
            }
            if (carcheckDic.ContainsKey("F_26"))
            {
                carcheckEntity.F_26 = true;
            }
            if (carcheckDic.ContainsKey("F_27"))
            {
                carcheckEntity.F_27 = true;
            }
            if (carcheckDic.ContainsKey("F_28"))
            {
                carcheckEntity.F_28 = true;
            }
            if (carcheckDic.ContainsKey("F_29"))
            {
                carcheckEntity.F_29 = true;
            }
            if (carcheckDic.ContainsKey("F_30"))
            {
                carcheckEntity.F_30 = true;
            }
            if (carcheckDic.ContainsKey("F_31"))
            {
                carcheckEntity.F_31 = true;
            }
            if (carcheckDic.ContainsKey("F_32"))
            {
                carcheckEntity.F_32 = true;
            }
            if (carcheckDic.ContainsKey("F_33"))
            {
                carcheckEntity.F_33 = true;
            }
            if (carcheckDic.ContainsKey("F_34"))
            {
                carcheckEntity.F_34 = true;
            }
            if (carcheckDic.ContainsKey("F_35"))
            {
                carcheckEntity.F_35 = true;
            }
            if (carcheckDic.ContainsKey("F_36"))
            {
                carcheckEntity.F_36 = true;
            }
            if (carcheckDic.ContainsKey("F_37"))
            {
                carcheckEntity.F_37 = true;
            }
            if (carcheckDic.ContainsKey("F_38"))
            {
                carcheckEntity.F_38 = true;
            }
            if (carcheckDic.ContainsKey("F_39"))
            {
                carcheckEntity.F_39 = true;
            }
            if (carcheckDic.ContainsKey("F_Remakes"))
            {
                carcheckEntity.F_Remakes = carcheckDic["F_Remakes"].Trim();
            }
            if (!string.IsNullOrEmpty(keyValue))
            {
                carcheckEntity.Modify(keyValue);
                service.Update(carcheckEntity);
            }
            else
            {
                carcheckEntity.Create();
                service.Insert(carcheckEntity);
            }
        }
    }
}
