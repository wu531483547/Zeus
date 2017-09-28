using System.Collections.Generic;
using Zeus.Domain;
using Zeus.IRepository.SystemManage;
using Zeus.Model;

namespace Zeus.Repository.SystemManage
{
    public class RoleRepository : RepositoryBase<Sys_Role>, IRoleRepository
    {
        public void DeleteForm(string keyValue)
        {
            using (var db = new RepositoryBase().BeginTrans())
            {
                db.Delete<Sys_Role>(t => t.F_Id == keyValue);
                db.Delete<Sys_RoleAuthorize>(t => t.F_ObjectId == keyValue);
                db.Commit();
            }
        }
        public void SubmitForm(Sys_Role roleEntity, List<Sys_RoleAuthorize> roleAuthorizeEntitys, string keyValue)
        {
            using (var db = new RepositoryBase().BeginTrans())
            {
                if (!string.IsNullOrEmpty(keyValue))
                {
                    db.Update(roleEntity);
                }
                else
                {
                    roleEntity.F_Category = 1;
                    db.Insert(roleEntity);
                }
                db.Delete<Sys_RoleAuthorize>(t => t.F_ObjectId == roleEntity.F_Id);
                db.Insert(roleAuthorizeEntitys);
                db.Commit();
            }
        }
    }
}
