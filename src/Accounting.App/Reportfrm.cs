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
    public partial class Reportfrm : Form
    {
        public int TypeID = 1;
        public Reportfrm()
        {
            InitializeComponent();
        }

        private void Reportfrm_Load(object sender, EventArgs e)
        {
            if (TypeID == 1)
            {
                this.Text = "InCome Report";
            }
            else
            {
                this.Text = "Cost Report";
            }
        }
    }
}
