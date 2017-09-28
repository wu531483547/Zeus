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

using System.Collections.Generic;
using System.Linq;
using Zeus.Model;
using Zeus.IRepository.Routine;
using Zeus.Repository.Routine;
using System;

namespace Zeus.Application.Routine
{
    public class CarCheckApp
    {
        private ICarCheckRepository service = new CarCheckRepository();

        public List<A_CarCheck> GetList()
        {
            return service.IQueryable().OrderBy(t => t.F_CreatorTime).ToList();
        }
        public A_CarCheck GetSingle(string keyValue)
        {
            return service.FindEntity(keyValue);
        }
        public void DeleteSingle(string keyValue)
        {
            service.Delete(t => t.F_Id == keyValue);
        }
        public void SubmitSingle(A_CarCheck jdccyEntity, string keyValue)
        {
            if (!string.IsNullOrEmpty(keyValue))
            {
                service.Update(jdccyEntity);
            }
            else
            {
                service.Insert(jdccyEntity);
            }
        }
    }
}
