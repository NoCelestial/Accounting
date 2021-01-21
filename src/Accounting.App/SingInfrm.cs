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
    public partial class SingInfrm : Form
    {
        public bool IsEdit = false;
        public SingInfrm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (IsEdit)
            {
                this.Close();
                return;
            }
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MainContext db = new MainContext())
            {
                if (IsEdit)
                {
                    var user = db.BaseRepositorySingIn.Get().First();
                    user.SingInUserName = txtun.Text;
                    user.SingInPassword = txtpw.Text;
                    db.BaseRepositorySingIn.Update(user);
                    db.Save();
                    DialogResult = DialogResult.OK;
                    Application.Restart();
                }
                else
                {
                    if (db.BaseRepositorySingIn.Get(s => s.SingInUserName == txtun.Text && s.SingInPassword == txtpw.Text).Any())
                    {
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("UserName Or Password Is Wrong ...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void SingInfrm_Load(object sender, EventArgs e)
        {
            if (IsEdit)
            {
                this.Text = "Edit SingIn Settings";
                using (MainContext db = new MainContext())
                {
                    var user = db.BaseRepositorySingIn.Get().First();
                    txtun.Text = user.SingInUserName;
                    txtpw.Text = user.SingInPassword;
                }
                button1.Text = "Save";
            }
        }
    }
}
