#region 版权说明
/*****************************************************************************
* Copyright (c) 2017 All Rights Reserved.
* CLR版本： 4.0.30319.42000 
*机器名称：DESKTOP-FUHBS8L
*公司名称：
*命名空间：Ares.Model  
*文件名：  DbLogType 
*版本号：  V1.0.0.0
*唯一标识：d3fbdd9f-b647-43b2-a848-ab520376be87
*当前的用户域：DESKTOP-FUHBS8L
*创建人：  Rex
*电子邮箱：
*创建时间：2017/9/8 8:54:04 

*描述：
*
*=====================================================================
*修改标记
*修改时间：2017/9/8 8:54:04 
*修改人： HY-REX 
*版本号： V1.0.0.0
*描述：
*
*****************************************************************************/
#endregion

using System.ComponentModel;

namespace Zeus.Model
{
    public enum DbLogType
    {
        [Description("其他")]
        Other = 0,
        [Description("登录")]
        Login = 1,
        [Description("退出")]
        Exit = 2,
        [Description("访问")]
        Visit = 3,
        [Description("新增")]
        Create = 4,
        [Description("删除")]
        Delete = 5,
        [Description("修改")]
        Update = 6,
        [Description("提交")]
        Submit = 7,
        [Description("异常")]
        Exception = 8,
    }
}
