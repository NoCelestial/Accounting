﻿
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainfrm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnsetting = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btmcustomer = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
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
            this.btnsetting.Image = ((System.Drawing.Image)(resources.GetObject("btnsetting.Image")));
            this.btnsetting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnsetting.Name = "btnsetting";
            this.btnsetting.Size = new System.Drawing.Size(62, 22);
            this.btnsetting.Text = "Settings";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btmcustomer});
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
            // Mainfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 455);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Mainfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accounting";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton btnsetting;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btmcustomer;
    }
}