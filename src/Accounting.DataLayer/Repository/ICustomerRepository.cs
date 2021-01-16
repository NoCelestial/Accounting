using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Repository
{
    public interface ICustomerRepository
    {
        IEnumerable<Customers> GetAllCustomers();
        Customers GetCustomerById(int id);
        bool InsertCustomer(Customers customer);
        bool UpdateCustomer(Customers customer);
        bool DeleteCustomer(Customers customer);
        bool DeleteCustomer(int id);
        void Save();
    }
}
