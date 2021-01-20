using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.ViewModel
{
   public class ReportViewModel
    {
        public int ID { get; set; }
        public string CustomerName { get; set; }
        public int Amount { get; set; }
        public DateTime DateTime { get; set; }
        public string Description { get; set; }
    }
}
