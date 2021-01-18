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
using Accounting.DataLayer;
using ValidationComponents;
using Accounting = Accounting.DataLayer.Accounting;

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

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCustomer.Text = dgvCustomer.CurrentRow.Cells[1].Value.ToString();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                DataLayer.Accounting accounting = new DataLayer.Accounting()
                {
                    CustomerID = int.Parse(dgvCustomer.CurrentRow.Cells[0].Value.ToString()),
                    TypeID = byte.Parse(((rbtnInCome.Checked) ? 1 : 2).ToString()),
                    Amount = int.Parse(numericUpDown1.Text.ToString()),
                    DateTime = DateTime.Now,
                    Description = textBox1.Text
                };
                db.BaseRepositoryAccounting.Insert(accounting);
                db.Save();
                DialogResult = DialogResult.OK;
            }
        }
    }
}
