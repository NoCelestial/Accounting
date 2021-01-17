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
    public partial class CustomerManagefrm : Form
    {
        public CustomerManagefrm()
        {
            InitializeComponent();
        }

        private void CustomerManagefrm_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        void BindGrid()
        {
            using (MainContext context = new MainContext())
            {
                dgvmain.AutoGenerateColumns = false;
                dgvmain.DataSource = context.CustomerRepository.GetAllCustomers();
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            BindGrid();
        }
    }
}
