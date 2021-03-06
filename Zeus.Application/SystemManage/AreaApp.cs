﻿using Zeus.Model;
using Zeus.Repository.SystemManage;
using Zeus.IRepository.SystemManage;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Zeus.Application.SystemManage
{
    public class AreaApp
    {
        private IAreaRepository service = new AreaRepository();

        public List<Sys_Area> GetList()
        {
            return service.IQueryable().ToList();
        }
        public Sys_Area GetForm(string keyValue)
        {
            return service.FindEntity(keyValue);
        }
        public void DeleteForm(string keyValue)
        {
            if (service.IQueryable().Count(t => t.F_ParentId.Equals(keyValue)) > 0)
            {
                throw new Exception("删除失败！操作的对象包含了下级数据。");
            }
            else
            {
                service.Delete(t => t.F_Id == keyValue);
            }
        }
        public void SubmitForm(Sys_Area areaEntity, string keyValue)
        {
            if (!string.IsNullOrEmpty(keyValue))
            {
                areaEntity.Modify(keyValue);
                service.Update(areaEntity);
            }
            else
            {
                areaEntity.Create();
                service.Insert(areaEntity);
            }
        }
    }
}
