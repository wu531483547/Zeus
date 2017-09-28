using Zeus.Core;
using Zeus.IRepository.SystemManage;
using Zeus.Model;
using Zeus.Repository.SystemManage;

namespace Zeus.Application.SystemManage
{
    public class UserLogOnApp
    {
        private IUserLogOnRepository service = new UserLogOnRepository();

        public Sys_UserLogOn GetForm(string keyValue)
        {
            return service.FindEntity(keyValue);
        }
        public void UpdateForm(Sys_UserLogOn userLogOnEntity)
        {
            service.Update(userLogOnEntity);
        }
        public void RevisePassword(string userPassword,string keyValue)
        {
            Sys_UserLogOn userLogOnEntity = new Sys_UserLogOn();
            userLogOnEntity.F_Id = keyValue;
            userLogOnEntity.F_UserSecretkey = Md5.MD5_16(Common.CreateNo()).ToLower();
            userLogOnEntity.F_UserPassword = Md5.MD5_32(DESEncrypt.Encrypt(Md5.MD5_32(userPassword).ToLower(), userLogOnEntity.F_UserSecretkey).ToLower()).ToLower();
            service.Update(userLogOnEntity);
        }
    }
}
