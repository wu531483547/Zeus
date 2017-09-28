using System.Collections.Generic;
using Zeus.Domain;
using Zeus.Model;

namespace Zeus.IRepository.SystemManage
{
    public interface IItemsDetailRepository : IRepositoryBase<Sys_ItemsDetail>
    {
        List<Sys_ItemsDetail> GetItemList(string enCode);
    }
}
