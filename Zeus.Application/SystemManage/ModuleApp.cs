using Zeus.Core;
using Zeus.Model;
using Zeus.Repository.SystemManage;
using System;
using System.Collections.Generic;
using System.Linq;
using Zeus.IRepository.SystemManage;

namespace Zeus.Application.SystemManage
{
    public class ModuleApp
    {
        private IModuleRepository service = new ModuleRepository();

        public List<Sys_Module> GetList()
        {
            return service.IQueryable().OrderBy(t => t.F_SortCode).ToList();
        }
        public Sys_Module GetForm(string keyValue)
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
        public void SubmitForm(Sys_Module moduleEntity, string keyValue)
        {
            if (!string.IsNullOrEmpty(keyValue))
            {
                moduleEntity.Modify(keyValue);
                service.Update(moduleEntity);
            }
            else
            {
                moduleEntity.Create();
                service.Insert(moduleEntity);
            }
        }
    }
}
