#region 版权说明
/*****************************************************************************
* Copyright (c) 2017 All Rights Reserved.
* CLR版本： 4.0.30319.42000 
*机器名称：DESKTOP-FUHBS8L
*公司名称：
*命名空间：Ares.Data  
*文件名：  IRepositoryBase 
*版本号：  V1.0.0.0
*唯一标识：295982d6-7ff8-4ac1-835a-1105764409fd
*当前的用户域：DESKTOP-FUHBS8L
*创建人：  Rex
*电子邮箱：
*创建时间：2017/9/8 8:41:08 

*描述：
*
*=====================================================================
*修改标记
*修改时间：2017/9/8 8:41:08 
*修改人： HY-REX 
*版本号： V1.0.0.0
*描述：
*
*****************************************************************************/
#endregion

using Zeus.Core;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Linq.Expressions;

namespace Zeus.Domain
{
    public interface IRepositoryBase : IDisposable
    {
        IRepositoryBase BeginTrans();
        int Commit();
        int Insert<TEntity>(TEntity entity) where TEntity : class;
        int Insert<TEntity>(List<TEntity> entitys) where TEntity : class;
        int Update<TEntity>(TEntity entity) where TEntity : class;
        int Delete<TEntity>(TEntity entity) where TEntity : class;
        int Delete<TEntity>(Expression<Func<TEntity, bool>> predicate) where TEntity : class;
        TEntity FindEntity<TEntity>(object keyValue) where TEntity : class;
        TEntity FindEntity<TEntity>(Expression<Func<TEntity, bool>> predicate) where TEntity : class;
        IQueryable<TEntity> IQueryable<TEntity>() where TEntity : class;
        IQueryable<TEntity> IQueryable<TEntity>(Expression<Func<TEntity, bool>> predicate) where TEntity : class;
        List<TEntity> FindList<TEntity>(string strSql) where TEntity : class;
        List<TEntity> FindList<TEntity>(string strSql, DbParameter[] dbParameter) where TEntity : class;
        List<TEntity> FindList<TEntity>(Pagination pagination) where TEntity : class, new();
        List<TEntity> FindList<TEntity>(Expression<Func<TEntity, bool>> predicate, Pagination pagination) where TEntity : class, new();
    }
}

