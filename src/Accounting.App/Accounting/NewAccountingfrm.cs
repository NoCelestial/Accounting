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
        public int AID = 0;
        public NewAccountingfrm()
        {
            InitializeComponent();
        }

        private void NewAccountingfrm_Load(object sender, EventArgs e)
        {
            if (AID != 0)
            {
                this.Text = "Edit Accounting";
                DataLayer.Accounting accounting = db.BaseRepositoryAccounting.GetById(AID);
                txtCustomer.Text = accounting.Customers.FullName.ToString();
                var rbtncostChecked = (accounting.TypeID == 1) ? rbtnInCome.Checked = true : rbtncost.Checked = true;
                numericUpDown1.Text = accounting.Amount.ToString();
                textBox1.Text = accounting.Description.ToString();
            }
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
                if (AID == 0)
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
                }
                else
                {
                    DataLayer.Accounting myAccounting = db.BaseRepositoryAccounting.GetById(AID);
                    myAccounting.CustomerID = db.CustomerRepository.GetCustomersByName(txtCustomer.Text).CustomersID;
                    myAccounting.Amount = int.Parse(numericUpDown1.Text);
                    myAccounting.Description = textBox1.Text;
                    myAccounting.TypeID = byte.Parse((((rbtnInCome.Checked) ? 1 : 2).ToString()));
                    db.BaseRepositoryAccounting.Update(myAccounting);
                }
                db.Save();
                DialogResult = DialogResult.OK;
            }
        }
    }
}
