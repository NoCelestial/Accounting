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
        }
    }
}
