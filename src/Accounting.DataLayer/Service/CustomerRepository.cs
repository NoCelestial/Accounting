using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.DataLayer.Repository;

namespace Accounting.DataLayer.Service
{
    public class CustomerRepository:ICustomerRepository
    {
        private Accounting_DBEntities context;

        public CustomerRepository(Accounting_DBEntities context)
        {
            this.context = context;
        }
        public IEnumerable<Customers> GetAllCustomers()
        {
            return context.Customers.ToList();
        }

        public IEnumerable<Customers> GetCustomersByFilter(string parameter)
        {
            return context.Customers.Where(c => c.FullName.Contains(parameter) || c.Email.Contains(parameter) || c.Mobile.Contains(parameter)).ToList();
        }

        public Customers GetCustomerById(int id)
        {
            return context.Customers.SingleOrDefault(c => c.CustomersID == id);
        }

        public bool InsertCustomer(Customers customer)
        {
            try
            {
                context.Customers.Add(customer);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateCustomer(Customers customer)
        {
            try
            {
                context.Customers.Attach(customer);
                context.Entry(customer).State = EntityState.Modified;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteCustomer(Customers customer)
        {
            try
            {
                if (context.Entry(customer).State == EntityState.Detached)
                {
                    context.Customers.Attach(customer);
                }
                context.Entry(customer).State = EntityState.Deleted;
                return true;
            }
            catch 
            {
                return false;
            }
        }

        public bool DeleteCustomer(int id)
        {
            try
            {
                var cutomer = GetCustomerById(id);
                DeleteCustomer(cutomer);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Customers GetCustomersByName(string name)
        {
            return context.Customers.SingleOrDefault(c => c.FullName == name);
        }

        public string GetCustomerNameById(int id)
        {
            return context.Customers.Find(id).FullName;
        }
    }
}
