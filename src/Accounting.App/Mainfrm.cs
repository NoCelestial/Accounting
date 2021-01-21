﻿using System;
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
        }

        private void btnNewAccounting_Click(object sender, EventArgs e)
        {
            NewAccountingfrm frm = new NewAccountingfrm();
            frm.ShowDialog();
        }

        private void btnreportincome_Click(object sender, EventArgs e)
        {
            Reportfrm frm = new Reportfrm();
            frm.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Reportfrm frm = new Reportfrm();
            frm.TypeID = 2;
            frm.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = DateTime.Now.ToLongTimeString();
        }

        private void Mainfrm_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongDateString();
        }
    }
}
