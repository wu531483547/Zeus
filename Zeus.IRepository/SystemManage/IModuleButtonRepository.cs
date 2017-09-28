using System.Collections.Generic;
using Zeus.Domain;
using Zeus.Model;

namespace Zeus.IRepository.SystemManage
{
    public interface IModuleButtonRepository : IRepositoryBase<Sys_ModuleButton>
    {
        void SubmitCloneButton(List<Sys_ModuleButton> entitys);
    }
}
