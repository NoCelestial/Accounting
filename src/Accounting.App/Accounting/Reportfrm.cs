using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accounting.DataLayer.Context;
using Accounting.DataLayer.ViewModel;

namespace Accounting.App
{
    public partial class Reportfrm : Form
    {
        public int TypeID = 1;
        public Reportfrm()
        {
            InitializeComponent();
        }

        private void Reportfrm_Load(object sender, EventArgs e)
        {
            using (MainContext db = new MainContext())
            {
                if (TypeID == 1)
                {
                    this.Text = "InCome Report";
                }
                else
                {
                    this.Text = "Cost Report";
                }

                cbcustomers.DataSource = db.CustomerRepository.GetAllCustomers();
                cbcustomers.DisplayMember = "FullName";
                cbcustomers.ValueMember = "CustomersID";
                Filter(true);
            }
        }

        private void btnapply_Click(object sender, EventArgs e)
        {
            Filter();
        }

        void Filter(bool basefilter=false)
        {
            using (MainContext db = new MainContext())
            {
                List<DataLayer.Accounting> result = db.BaseRepositoryAccounting.Get(a => a.TypeID == TypeID).ToList();
                if (!basefilter)
                {
                    result = result.Where(r => r.CustomerID == (int)cbcustomers.SelectedValue).ToList();
                }

                if (txtdatein.Text != "    /  /")
                {

                    result = result.Where(r => r.DateTime >= Convert.ToDateTime(txtdatein.Text)).ToList();
                }

                if (txtdateout.Text != "    /  /")
                {
                    result = result.Where(r => r.DateTime <= Convert.ToDateTime(txtdateout.Text)).ToList();
                }
                List<ReportViewModel> reportViewModels = new List<ReportViewModel>();
                foreach (var accounting in result)
                {
                    reportViewModels.Add(new ReportViewModel()
                    {
                        ID = accounting.ID,
                        DateTime = accounting.DateTime,
                        Description = accounting.Description,
                        Amount = accounting.Amount,
                        CustomerName = db.CustomerRepository.GetCustomerNameById(accounting.CustomerID)
                    });
                }

                dgvmain.AutoGenerateColumns = false;
                dgvmain.DataSource = reportViewModels;
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            Filter();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (dgvmain.CurrentRow != null)
            {
                int acid = int.Parse(dgvmain.CurrentRow.Cells["ID"].Value.ToString());
                if (MessageBox.Show("Are You Sure?","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
                {
                    using (MainContext db = new MainContext())
                    {
                        db.BaseRepositoryAccounting.Delete(acid);
                        db.Save();
                    }
                }
                Filter();
                return;
            }

            MessageBox.Show("Please Select a Row ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (dgvmain.CurrentRow != null)
            {
                int acid = int.Parse(dgvmain.CurrentRow.Cells["ID"].Value.ToString());
                NewAccountingfrm frm = new NewAccountingfrm();
                frm.AID = acid;
                frm.ShowDialog();
                Filter();
                return;
            }

            MessageBox.Show("Please Select a Row ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Customer");
            dt.Columns.Add("Amount");
            dt.Columns.Add("DateTime");
            dt.Columns.Add("Description");
            foreach (DataGridViewRow dataGridViewRow in dgvmain.Rows)
            {
                dt.Rows.Add(
                    dataGridViewRow.Cells[1].Value.ToString(),
                    dataGridViewRow.Cells[2].Value.ToString(),
                    dataGridViewRow.Cells[3].Value.ToString(),
                    dataGridViewRow.Cells[4].Value.ToString()
                    );
            }
            stiReport1.Load(Application.StartupPath+"/Report.mrt");
            stiReport1.RegData("dt",dt);
            stiReport1.Show();
        }
    }
}
