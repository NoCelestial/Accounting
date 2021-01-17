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
        public int customerID = 0;
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
                    pictureBox1.Image.Save(path + imagename);
                    Customers customer = new Customers()
                    {
                        FullName = txtname.Text,
                        Address = txtaddress.Text,
                        Email = txtemail.Text,
                        Mobile = txtmobile.Text,
                        CustomerImage = imagename
                    };
                    if (customerID == 0)
                    {
                        db.CustomerRepository.InsertCustomer(customer);
                    }
                    else
                    {
                        var editcustomer = db.CustomerRepository.GetCustomerById(customerID);
                        db.CustomerRepository.UpdateCustomer(editcustomer);
                    }
                    db.Save();
                }
                DialogResult = DialogResult.OK;
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AECustomerfrm_Load(object sender, EventArgs e)
        {
            if (customerID != 0)
            {
                this.Text = "Edit Customer";
                using (MainContext db = new MainContext())
                {
                    var customer = db.CustomerRepository.GetCustomerById(customerID);
                    txtaddress.Text = customer.Address;
                    txtemail.Text = customer.Email;
                    txtmobile.Text = customer.Mobile;
                    txtname.Text = customer.FullName;
                    pictureBox1.ImageLocation = Application.StartupPath + "/Images/" + customer.CustomerImage;
                }
            }
        }
    }
}
