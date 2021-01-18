using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accounting.DataLayer.Context;

namespace Accounting.App
{
    public partial class NewAccountingfrm : Form
    {
        MainContext db = new MainContext();
        public NewAccountingfrm()
        {
            InitializeComponent();
        }

        private void NewAccountingfrm_Load(object sender, EventArgs e)
        {
            dgvCustomer.AutoGenerateColumns = false;
            dgvCustomer.DataSource = db.CustomerRepository.GetAllCustomers();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            dgvCustomer.DataSource = db.CustomerRepository.GetCustomersByFilter(txtFilter.Text);
        }
    }
}
