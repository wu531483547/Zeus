using Zeus.Core;
using Zeus.Domain;
using Zeus.IRepository.SystemManage;
using Zeus.Model;

namespace Zeus.Repository.SystemManage
{
    public class UserRepository : RepositoryBase<Sys_User>, IUserRepository
    {
        public void DeleteForm(string keyValue)
        {
            using (var db = new RepositoryBase().BeginTrans())
            {
                db.Delete<Sys_User>(t => t.F_Id == keyValue);
                db.Delete<Sys_UserLogOn>(t => t.F_UserId == keyValue);
                db.Commit();
            }
        }
        public void SubmitForm(Sys_User userEntity, Sys_UserLogOn userLogOnEntity, string keyValue)
        {
            using (var db = new RepositoryBase().BeginTrans())
            {
                if (!string.IsNullOrEmpty(keyValue))
                {
                    db.Update(userEntity);
                }
                else
                {
                    userLogOnEntity.F_Id = userEntity.F_Id;
                    userLogOnEntity.F_UserId = userEntity.F_Id;
                    userLogOnEntity.F_UserSecretkey = Md5.MD5_16(Common.CreateNo()).ToLower();
                    userLogOnEntity.F_UserPassword = Md5.MD5_32(DESEncrypt.Encrypt(Md5.MD5_32(userLogOnEntity.F_UserPassword).ToLower(), userLogOnEntity.F_UserSecretkey).ToLower()).ToLower();
                    db.Insert(userEntity);
                    db.Insert(userLogOnEntity);
                }
                db.Commit();
            }
        }
    }
}
