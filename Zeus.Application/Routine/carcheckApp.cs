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
using Zeus.Core;
using Zeus.IRepository.Routine;
using Zeus.Model;
using Zeus.Repository.Routine;

namespace Zeus.Application.Routine
{
    public class CarCheckApp
    {
        private ICarCheckRepository service = new CarCheckRepository();

        public List<A_CarCheck> GetList(DateTime BeginTime, DateTime EndTime,string sTake)
        {
            EndTime = EndTime.AddDays(1);
            int iTake = sTake.ToInt();
            return service.IQueryable().Where(t => DbFunctions.TruncateTime(t.F_CreatorTime) >= BeginTime
            && DbFunctions.TruncateTime(t.F_CreatorTime) <= EndTime).OrderByDescending(t => t.F_CreatorTime).Take(iTake).ToList();
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
            carcheckEntity.F_6 = carcheckDic.ContainsKey("F_6") == true ? true : false;
            carcheckEntity.F_7 = carcheckDic.ContainsKey("F_7") == true ? true : false;
            carcheckEntity.F_8 = carcheckDic.ContainsKey("F_8") == true ? true : false;
            carcheckEntity.F_9 = carcheckDic.ContainsKey("F_9") == true ? true : false;
            carcheckEntity.F_10 = carcheckDic.ContainsKey("F_10") == true ? true : false;
            carcheckEntity.F_11 = carcheckDic.ContainsKey("F_11") == true ? true : false;
            carcheckEntity.F_12 = carcheckDic.ContainsKey("F_12") == true ? true : false;
            carcheckEntity.F_13 = carcheckDic.ContainsKey("F_13") == true ? true : false;
            carcheckEntity.F_14 = carcheckDic.ContainsKey("F_14") == true ? true : false;
            carcheckEntity.F_15 = carcheckDic.ContainsKey("F_15") == true ? true : false;
            carcheckEntity.F_16 = carcheckDic.ContainsKey("F_16") == true ? true : false;
            carcheckEntity.F_17 = carcheckDic.ContainsKey("F_17") == true ? true : false;
            carcheckEntity.F_18 = carcheckDic.ContainsKey("F_18") == true ? true : false;
            carcheckEntity.F_19 = carcheckDic.ContainsKey("F_19") == true ? true : false;
            carcheckEntity.F_20 = carcheckDic.ContainsKey("F_20") == true ? true : false;
            carcheckEntity.F_21 = carcheckDic.ContainsKey("F_21") == true ? true : false;
            carcheckEntity.F_22 = carcheckDic.ContainsKey("F_22") == true ? true : false;
            carcheckEntity.F_23 = carcheckDic.ContainsKey("F_23") == true ? true : false;
            carcheckEntity.F_24 = carcheckDic.ContainsKey("F_24") == true ? true : false;
            carcheckEntity.F_25 = carcheckDic.ContainsKey("F_25") == true ? true : false;
            carcheckEntity.F_26 = carcheckDic.ContainsKey("F_26") == true ? true : false;
            carcheckEntity.F_27 = carcheckDic.ContainsKey("F_27") == true ? true : false;
            carcheckEntity.F_28 = carcheckDic.ContainsKey("F_28") == true ? true : false;
            carcheckEntity.F_29 = carcheckDic.ContainsKey("F_29") == true ? true : false;
            carcheckEntity.F_30 = carcheckDic.ContainsKey("F_30") == true ? true : false;
            carcheckEntity.F_31 = carcheckDic.ContainsKey("F_31") == true ? true : false;
            carcheckEntity.F_32 = carcheckDic.ContainsKey("F_32") == true ? true : false;
            carcheckEntity.F_33 = carcheckDic.ContainsKey("F_33") == true ? true : false;
            carcheckEntity.F_34 = carcheckDic.ContainsKey("F_34") == true ? true : false;
            carcheckEntity.F_35 = carcheckDic.ContainsKey("F_35") == true ? true : false;
            carcheckEntity.F_36 = carcheckDic.ContainsKey("F_36") == true ? true : false;
            carcheckEntity.F_37 = carcheckDic.ContainsKey("F_37") == true ? true : false;
            carcheckEntity.F_38 = carcheckDic.ContainsKey("F_38") == true ? true : false;
            carcheckEntity.F_39 = carcheckDic.ContainsKey("F_39") == true ? true : false;
            if (carcheckDic.ContainsKey("F_40"))
            {
                carcheckEntity.F_40 = carcheckDic["F_40"].Trim();
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
        public void CreateQrCode(string carNumber)
        {
            QrCode QC = new QrCode();
            QC.CreateCode_Choose("CG" + carNumber, "Byte", "L", 0, 4);
        }
    }
}
