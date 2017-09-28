using Zeus.Core;
using Zeus.Model;
using Zeus.Repository.SystemSecurity;
using System.Collections.Generic;
using System.Linq;
using Zeus.IRepository.SystemSecurity;

namespace Zeus.Application.SystemSecurity
{
    public class FilterIPApp
    {
        private IFilterIPRepository service = new FilterIPRepository();

        public List<Sys_FilterIP> GetList(string keyword)
        {
            var expression = ExtLinq.True<Sys_FilterIP>();
            if (!string.IsNullOrEmpty(keyword))
            {
                expression = expression.And(t => t.F_StartIP.Contains(keyword));
            }
            return service.IQueryable(expression).OrderByDescending(t => t.F_DeleteTime).ToList();
        }
        public Sys_FilterIP GetForm(string keyValue)
        {
            return service.FindEntity(keyValue);
        }
        public void DeleteForm(string keyValue)
        {
            service.Delete(t => t.F_Id == keyValue);
        }
        public void SubmitForm(Sys_FilterIP filterIPEntity, string keyValue)
        {
            if (!string.IsNullOrEmpty(keyValue))
            {
                filterIPEntity.Modify(keyValue);
                service.Update(filterIPEntity);
            }
            else
            {
                filterIPEntity.Create();
                service.Insert(filterIPEntity);
            }
        }
    }
}
