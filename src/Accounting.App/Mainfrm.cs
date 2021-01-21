using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting.App
{
    public partial class Mainfrm : Form
    {
        public Mainfrm()
        {
            InitializeComponent();
        }

        private void btmcustomer_Click(object sender, EventArgs e)
        {
            CustomerManagefrm frm = new CustomerManagefrm();
            frm.ShowDialog();
            Report();
        }

        private void btnNewAccounting_Click(object sender, EventArgs e)
        {
            NewAccountingfrm frm = new NewAccountingfrm();
            frm.ShowDialog();
            Report();
        }

        private void btnreportincome_Click(object sender, EventArgs e)
        {
            Reportfrm frm = new Reportfrm();
            frm.ShowDialog();
            Report();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Reportfrm frm = new Reportfrm();
            frm.TypeID = 2;
            frm.ShowDialog();
            Report();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = DateTime.Now.ToLongTimeString();
        }

        private void Mainfrm_Load(object sender, EventArgs e)
        {
            this.Hide();
            SingInfrm frm = new SingInfrm();
            if (frm.ShowDialog()==DialogResult.OK)
            {
                this.Show();
                lblDate.Text = DateTime.Now.ToLongDateString();
                Report();
            }
            else
            {
                Application.Exit();
            }
        }

        void Report()
        {
           var rep =  Account.MainFormReport();
           lblincome.Text = rep.InCome.ToString();
           lblcost.Text = rep.Cost.ToString();
           lblbalance.Text = rep.Balance.ToString();
        }
        private void btnsinginsetting_Click(object sender, EventArgs e)
        {
            SingInfrm frm = new SingInfrm();
            frm.IsEdit = true;
            frm.ShowDialog();
        }
    }
}
