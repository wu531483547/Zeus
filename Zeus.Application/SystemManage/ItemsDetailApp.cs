using Zeus.Core;
using Zeus.Model;
using Zeus.Repository.SystemManage;
using System.Collections.Generic;
using System.Linq;
using Zeus.IRepository.SystemManage;

namespace Zeus.Application.SystemManage
{
    public class ItemsDetailApp
    {
        private IItemsDetailRepository service = new ItemsDetailRepository();

        public List<Sys_ItemsDetail> GetList(string itemId = "", string keyword = "")
        {
            var expression = ExtLinq.True<Sys_ItemsDetail>();
            if (!string.IsNullOrEmpty(itemId))
            {
                expression = expression.And(t => t.F_ItemId == itemId);
            }
            if (!string.IsNullOrEmpty(keyword))
            {
                expression = expression.And(t => t.F_ItemName.Contains(keyword));
                expression = expression.Or(t => t.F_ItemCode.Contains(keyword));
            }
            return service.IQueryable(expression).OrderBy(t => t.F_SortCode).ToList();
        }
        public List<Sys_ItemsDetail> GetItemList(string enCode)
        {
            return service.GetItemList(enCode);
        }
        public Sys_ItemsDetail GetForm(string keyValue)
        {
            return service.FindEntity(keyValue);
        }
        public void DeleteForm(string keyValue)
        {
            service.Delete(t => t.F_Id == keyValue);
        }
        public void SubmitForm(Sys_ItemsDetail itemsDetailEntity, string keyValue)
        {
            if (!string.IsNullOrEmpty(keyValue))
            {
                itemsDetailEntity.Modify(keyValue);
                service.Update(itemsDetailEntity);
            }
            else
            {
                itemsDetailEntity.Create();
                service.Insert(itemsDetailEntity);
            }
        }
    }
}
