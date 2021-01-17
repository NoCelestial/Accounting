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
    public partial class AECustomerfrm : Form
    {
        public AECustomerfrm()
        {
            InitializeComponent();
        }

        private void btnpicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Multiselect = false;
            if (of.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.ImageLocation = of.FileName;
            }
            of.Dispose();
        }
    }
}
