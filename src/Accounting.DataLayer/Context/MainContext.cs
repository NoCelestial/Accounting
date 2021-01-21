using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.DataLayer.Repository;
using Accounting.DataLayer.Service;

namespace Accounting.DataLayer.Context
{
    public class MainContext:IDisposable
    {
        Accounting_DBEntities db = new Accounting_DBEntities();
        private ICustomerRepository _customerRepository;
        private BaseRepository<Accounting>  _baseRepositoryAccounting;
        private BaseRepository<SingIn> _baseRepositorySingIn;
            
        public ICustomerRepository CustomerRepository
        {
            get
            {
                if (_customerRepository == null)
                {
                    _customerRepository = new CustomerRepository(db);
                }

                return _customerRepository;
            }
        }
        public BaseRepository<Accounting> BaseRepositoryAccounting
        {
            get
            {
                if (_baseRepositoryAccounting == null)
                {
                    _baseRepositoryAccounting = new BaseRepository<Accounting>(db);
                }

                return _baseRepositoryAccounting;
            }   
        }
        public BaseRepository<SingIn> BaseRepositorySingIn
        {
            get
            {
                if (_baseRepositorySingIn== null)
                {
                    _baseRepositorySingIn = new BaseRepository<SingIn>(db);
                }

                return _baseRepositorySingIn;
            }
        }
        public void Save()
        {
            db.SaveChanges();
        }
        public void Dispose()
        {
            db.Dispose();
        }
    }
}
