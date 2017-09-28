using System.Collections.Generic;
using Zeus.Domain;
using Zeus.IRepository.SystemManage;
using Zeus.Model;

namespace Zeus.Repository.SystemManage
{
    public class ModuleButtonRepository : RepositoryBase<Sys_ModuleButton>, IModuleButtonRepository
    {
        public void SubmitCloneButton(List<Sys_ModuleButton> entitys)
        {
            using (var db = new RepositoryBase().BeginTrans())
            {
                foreach (var item in entitys)
                {
                    db.Insert(item);
                }
                db.Commit();
            }
        }
    }
}
