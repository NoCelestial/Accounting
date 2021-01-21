using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.DataLayer.Context;
using Accounting.DataLayer.ViewModel;

namespace Accounting.App
{
    public class Account
    {
        public static MonthReportViewModel MainFormReport()
        {
            DateTime sd = new DateTime(DateTime.Now.Year,DateTime.Now.Month,01);
            DateTime ed = new DateTime(DateTime.Now.Year,DateTime.Now.Month,30);
            MonthReportViewModel monthReportViewModel = new MonthReportViewModel();
            using (MainContext db =new MainContext())
            {
                var  income= db.BaseRepositoryAccounting.Get(a =>a.TypeID==1 && a.DateTime >= sd && a.DateTime <= ed).Select(a => a.Amount);
                var cost = db.BaseRepositoryAccounting.Get(a => a.TypeID == 2 && a.DateTime >= sd && a.DateTime <= ed).Select(a => a.Amount);
                monthReportViewModel.InCome = income.Sum();
                monthReportViewModel.Cost = cost.Sum();
                monthReportViewModel.Balance = (income.Sum() - cost.Sum());
                return monthReportViewModel;
            }
        }
    }
}
