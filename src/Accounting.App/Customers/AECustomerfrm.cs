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
using Accounting.DataLayer;
using Accounting.DataLayer.Context;
using ValidationComponents;

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

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                using (MainContext db = new MainContext())
                {
                    string imagename = Guid.NewGuid().ToString() + Path.GetExtension(pictureBox1.ImageLocation);
                    string path = Application.StartupPath + "/Images/";
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    pictureBox1.Image.Save(path+imagename);
                    Customers customer = new Customers()
                    {
                        FullName = txtname.Text,
                        Address = txtaddress.Text,
                        Email = txtemail.Text,
                        Mobile = txtmobile.Text,
                        CustomerImage = imagename
                    };
                    db.CustomerRepository.InsertCustomer(customer);
                    db.Save();
                }
                DialogResult = DialogResult.OK;
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
