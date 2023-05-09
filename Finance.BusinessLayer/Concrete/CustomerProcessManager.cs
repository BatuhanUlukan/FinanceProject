using Finance.EntityLayer.Concrete;
using Finance.BusinessLayer.Abstract;
using Finance.DataLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance.BusinessLayer.Concrete
{
    public class CustomerProcessManager : ICustomerProcessService
    {
        private readonly ICustomerProcessDal _customerProcessDal;

        public CustomerProcessManager(ICustomerProcessDal customerProcessDal)
        {
            _customerProcessDal = customerProcessDal;
        }

        public void TDelete(CustomerAccountProcess t)
        {
            _customerProcessDal.Delete(t);
        }

        public CustomerAccountProcess TGetByID(int id)
        {
            return _customerProcessDal.GetByID(id);
        }

        public List<CustomerAccountProcess> TGetList()
        {
            return _customerProcessDal.GetList();
        }

        public void TInsert(CustomerAccountProcess t)
        {
            _customerProcessDal.Insert(t);
        }

        public void TUpdate(CustomerAccountProcess t)
        {
            _customerProcessDal.Update(t);
        }
    }
}
