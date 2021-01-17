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
            toolStripTextBox1.Text = "";
            BindGrid();
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            using (MainContext db = new MainContext())
            {
                dgvmain.DataSource = db.CustomerRepository.GetCustomersByFilter(toolStripTextBox1.Text);
            }
        }

        private void btndeletecustomer_Click(object sender, EventArgs e)
        {
            if (dgvmain.CurrentRow != null)
            {
                
                using (MainContext db = new MainContext())
                {
                    string name = dgvmain.CurrentRow.Cells[1].Value.ToString();

                    int id = int.Parse(dgvmain.CurrentRow.Cells["CustomerID"].Value.ToString());
                    if (MessageBox.Show($"Are You Sure To Delete {name} Customer?", "Warning", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        db.CustomerRepository.DeleteCustomer(id);
                        db.Save();
                    }

                    BindGrid();
                }
            }
            else
            {
                MessageBox.Show("Please Select a Customer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnnewCustomer_Click(object sender, EventArgs e)
        {
            AECustomerfrm ae = new AECustomerfrm();
            ae.ShowDialog();
            BindGrid();
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            if (dgvmain.CurrentRow != null)
            {
                int id = int.Parse(dgvmain.CurrentRow.Cells["CustomerID"].Value.ToString());
                AECustomerfrm frm = new AECustomerfrm();
                frm.customerID = int.Parse(dgvmain.CurrentRow.Cells[0].Value.ToString());
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please Select a Customer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
