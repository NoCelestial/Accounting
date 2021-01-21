
namespace Accounting.App
{
    partial class Mainfrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainfrm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnsetting = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnsinginsetting = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btmcustomer = new System.Windows.Forms.ToolStripButton();
            this.btnNewAccounting = new System.Windows.Forms.ToolStripButton();
            this.btnreportincome = new System.Windows.Forms.ToolStripButton();
            this.btncost = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbltime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lblincome = new System.Windows.Forms.Label();
            this.lblcost = new System.Windows.Forms.Label();
            this.lblbalance = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnsetting});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(678, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnsetting
            // 
            this.btnsetting.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnsetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnsinginsetting});
            this.btnsetting.Image = ((System.Drawing.Image)(resources.GetObject("btnsetting.Image")));
            this.btnsetting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnsetting.Name = "btnsetting";
            this.btnsetting.Size = new System.Drawing.Size(62, 22);
            this.btnsetting.Text = "Settings";
            // 
            // btnsinginsetting
            // 
            this.btnsinginsetting.Name = "btnsinginsetting";
            this.btnsinginsetting.Size = new System.Drawing.Size(152, 22);
            this.btnsinginsetting.Text = "SingIn Settings";
            this.btnsinginsetting.Click += new System.EventHandler(this.btnsinginsetting_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btmcustomer,
            this.btnNewAccounting,
            this.btnreportincome,
            this.btncost});
            this.toolStrip2.Location = new System.Drawing.Point(0, 25);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(678, 62);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btmcustomer
            // 
            this.btmcustomer.Image = global::Accounting.App.Properties.Resources._1371476468_preferences_contact_list;
            this.btmcustomer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btmcustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btmcustomer.Name = "btmcustomer";
            this.btmcustomer.Size = new System.Drawing.Size(63, 59);
            this.btmcustomer.Text = "Customer";
            this.btmcustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btmcustomer.Click += new System.EventHandler(this.btmcustomer_Click);
            // 
            // btnNewAccounting
            // 
            this.btnNewAccounting.Image = global::Accounting.App.Properties.Resources._1371476499_todo_list;
            this.btnNewAccounting.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNewAccounting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewAccounting.Name = "btnNewAccounting";
            this.btnNewAccounting.Size = new System.Drawing.Size(100, 59);
            this.btnNewAccounting.Text = "New Accounting";
            this.btnNewAccounting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNewAccounting.Click += new System.EventHandler(this.btnNewAccounting_Click);
            // 
            // btnreportincome
            // 
            this.btnreportincome.Image = global::Accounting.App.Properties.Resources.servicesCosts;
            this.btnreportincome.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnreportincome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnreportincome.Name = "btnreportincome";
            this.btnreportincome.Size = new System.Drawing.Size(91, 59);
            this.btnreportincome.Text = "InCome Report";
            this.btnreportincome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnreportincome.Click += new System.EventHandler(this.btnreportincome_Click);
            // 
            // btncost
            // 
            this.btncost.Image = global::Accounting.App.Properties.Resources._1370791030_credit_card;
            this.btncost.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btncost.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btncost.Name = "btncost";
            this.btncost.Size = new System.Drawing.Size(73, 59);
            this.btncost.Text = "Cost Report";
            this.btncost.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btncost.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Accounting.App.Properties.Resources.Untitled_1;
            this.pictureBox1.Location = new System.Drawing.Point(412, 217);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 226);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblDate,
            this.lbltime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 433);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(678, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblDate
            // 
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 17);
            // 
            // lbltime
            // 
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(0, 17);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblbalance);
            this.groupBox1.Controls.Add(this.lblcost);
            this.groupBox1.Controls.Add(this.lblincome);
            this.groupBox1.Controls.Add(this.lbl);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 126);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Month Report";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "InCome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cost";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(11, 97);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(53, 17);
            this.lbl.TabIndex = 2;
            this.lbl.Text = "Balance";
            // 
            // lblincome
            // 
            this.lblincome.Location = new System.Drawing.Point(131, 19);
            this.lblincome.Name = "lblincome";
            this.lblincome.Size = new System.Drawing.Size(170, 17);
            this.lblincome.TabIndex = 3;
            this.lblincome.Text = "0";
            // 
            // lblcost
            // 
            this.lblcost.Location = new System.Drawing.Point(131, 54);
            this.lblcost.Name = "lblcost";
            this.lblcost.Size = new System.Drawing.Size(170, 13);
            this.lblcost.TabIndex = 4;
            this.lblcost.Text = "0";
            // 
            // lblbalance
            // 
            this.lblbalance.Location = new System.Drawing.Point(131, 97);
            this.lblbalance.Name = "lblbalance";
            this.lblbalance.Size = new System.Drawing.Size(170, 13);
            this.lblbalance.TabIndex = 5;
            this.lblbalance.Text = "0";
            // 
            // Mainfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 455);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Mainfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accounting";
            this.Load += new System.EventHandler(this.Mainfrm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton btnsetting;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btmcustomer;
        private System.Windows.Forms.ToolStripButton btnNewAccounting;
        private System.Windows.Forms.ToolStripButton btnreportincome;
        private System.Windows.Forms.ToolStripButton btncost;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblDate;
        private System.Windows.Forms.ToolStripStatusLabel lbltime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem btnsinginsetting;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblbalance;
        private System.Windows.Forms.Label lblcost;
        private System.Windows.Forms.Label lblincome;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}