#region 版权说明
/*****************************************************************************
* Copyright (c) 2017 All Rights Reserved.
* CLR版本： 4.0.30319.42000 
*机器名称：DESKTOP-FUHBS8L
*公司名称：
*命名空间：Ares.Data  
*文件名：  IRepositoryBase 
*版本号：  V1.0.0.0
*唯一标识：b886efa5-371a-458d-b5bc-986731aa97b3
*当前的用户域：DESKTOP-FUHBS8L
*创建人：  Rex
*电子邮箱：
*创建时间：2017/9/8 8:44:44 

*描述：
*
*=====================================================================
*修改标记
*修改时间：2017/9/8 8:44:44 
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
    /// <summary>
    /// 仓储接口
    /// </summary>
    /// <typeparam name="TEntity">实体类型</typeparam>
    public interface IRepositoryBase<TEntity> where TEntity : class, new()
    {
        int Insert(TEntity entity);
        int Insert(List<TEntity> entitys);
        int Update(TEntity entity);
        int Delete(TEntity entity);
        int Delete(Expression<Func<TEntity, bool>> predicate);
        TEntity FindEntity(object keyValue);
        TEntity FindEntity(Expression<Func<TEntity, bool>> predicate);
        IQueryable<TEntity> IQueryable();
        IQueryable<TEntity> IQueryable(Expression<Func<TEntity, bool>> predicate);
        List<TEntity> FindList(string strSql);
        List<TEntity> FindList(string strSql, DbParameter[] dbParameter);
        List<TEntity> FindList(Pagination pagination);
        List<TEntity> FindList(Expression<Func<TEntity, bool>> predicate, Pagination pagination);
    }
}

