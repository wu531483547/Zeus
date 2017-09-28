using Zeus.Domain;
using Zeus.Model;

namespace Zeus.IRepository.SystemSecurity
{
    public interface IDbBackupRepository : IRepositoryBase<Sys_DbBackup>
    {
        void DeleteForm(string keyValue);
        void ExecuteDbBackup(Sys_DbBackup dbBackupEntity);
    }
}
