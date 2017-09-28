using Zeus.Domain;
using Zeus.Model;

namespace Zeus.IRepository.SystemManage
{
    public interface IUserRepository : IRepositoryBase<Sys_User>
    {
        void DeleteForm(string keyValue);
        void SubmitForm(Sys_User userEntity, Sys_UserLogOn userLogOnEntity, string keyValue);
    }
}
