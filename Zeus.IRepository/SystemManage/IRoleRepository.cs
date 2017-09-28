using System.Collections.Generic;
using Zeus.Domain;
using Zeus.Model;

namespace Zeus.IRepository.SystemManage
{
    public interface IRoleRepository : IRepositoryBase<Sys_Role>
    {
        void DeleteForm(string keyValue);
        void SubmitForm(Sys_Role roleEntity, List<Sys_RoleAuthorize> roleAuthorizeEntitys, string keyValue);
    }
}
