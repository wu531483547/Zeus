﻿using Zeus.Core;
using Zeus.Domain;
using Zeus.IRepository.SystemSecurity;
using Zeus.Model;

namespace Zeus.Repository.SystemSecurity
{
    public class DbBackupRepository : RepositoryBase<Sys_DbBackup>, IDbBackupRepository
    {
        public void DeleteForm(string keyValue)
        {
            using (var db = new RepositoryBase().BeginTrans())
            {
                var dbBackupEntity = db.FindEntity<Sys_DbBackup>(keyValue);
                if (dbBackupEntity != null)
                {
                    FileHelper.DeleteFile(dbBackupEntity.F_FilePath);
                }
                db.Delete<Sys_DbBackup>(dbBackupEntity);
                db.Commit();
            }
        }
        public void ExecuteDbBackup(Sys_DbBackup dbBackupEntity)
        {
            DbHelper.ExecuteSqlCommand(string.Format("backup database {0} to disk ='{1}'", dbBackupEntity.F_DbName, dbBackupEntity.F_FilePath));
            dbBackupEntity.F_FileSize = FileHelper.ToFileSize(FileHelper.GetFileSize(dbBackupEntity.F_FilePath));
            dbBackupEntity.F_FilePath = "/Resource/DbBackup/" + dbBackupEntity.F_FileName;
            this.Insert(dbBackupEntity);
        }
    }
}
