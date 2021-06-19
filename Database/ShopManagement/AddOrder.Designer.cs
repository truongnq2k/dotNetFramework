
namespace ShopManagement
{
    partial class AddOrder
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
            this.pnTop = new System.Windows.Forms.Panel();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lbRequireDate = new System.Windows.Forms.Label();
            this.dtpRequiredDate = new System.Windows.Forms.DateTimePicker();
            this.lbShiper = new System.Windows.Forms.Label();
            this.lbEmployee = new System.Windows.Forms.Label();
            this.lbCustomer = new System.Windows.Forms.Label();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.cbEmployee = new System.Windows.Forms.ComboBox();
            this.cbShipper = new System.Windows.Forms.ComboBox();
            this.pnButtom = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnButtonRight = new System.Windows.Forms.Panel();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.pnButtonLeft = new System.Windows.Forms.Panel();
            this.lbProducts = new System.Windows.Forms.ListBox();
            this.pnTop.SuspendLayout();
            this.pnButtom.SuspendLayout();
            this.pnButtonRight.SuspendLayout();
            this.pnButtonLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnTop.Controls.Add(this.btnCreate);
            this.pnTop.Controls.Add(this.lbRequireDate);
            this.pnTop.Controls.Add(this.dtpRequiredDate);
            this.pnTop.Controls.Add(this.lbShiper);
            this.pnTop.Controls.Add(this.lbEmployee);
            this.pnTop.Controls.Add(this.lbCustomer);
            this.pnTop.Controls.Add(this.cbCustomer);
            this.pnTop.Controls.Add(this.cbEmployee);
            this.pnTop.Controls.Add(this.cbShipper);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(955, 117);
            this.pnTop.TabIndex = 0;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCreate.Location = new System.Drawing.Point(795, 12);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(98, 47);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            // 
            // lbRequireDate
            // 
            this.lbRequireDate.AutoSize = true;
            this.lbRequireDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRequireDate.Location = new System.Drawing.Point(459, 65);
            this.lbRequireDate.Name = "lbRequireDate";
            this.lbRequireDate.Size = new System.Drawing.Size(132, 24);
            this.lbRequireDate.TabIndex = 14;
            this.lbRequireDate.Text = "Require Date";
            // 
            // dtpRequiredDate
            // 
            this.dtpRequiredDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpRequiredDate.Location = new System.Drawing.Point(615, 65);
            this.dtpRequiredDate.Name = "dtpRequiredDate";
            this.dtpRequiredDate.Size = new System.Drawing.Size(278, 24);
            this.dtpRequiredDate.TabIndex = 13;
            // 
            // lbShiper
            // 
            this.lbShiper.AutoSize = true;
            this.lbShiper.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShiper.Location = new System.Drawing.Point(459, 19);
            this.lbShiper.Name = "lbShiper";
            this.lbShiper.Size = new System.Drawing.Size(83, 24);
            this.lbShiper.TabIndex = 12;
            this.lbShiper.Text = "Shipper";
            // 
            // lbEmployee
            // 
            this.lbEmployee.AutoSize = true;
            this.lbEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmployee.Location = new System.Drawing.Point(23, 65);
            this.lbEmployee.Name = "lbEmployee";
            this.lbEmployee.Size = new System.Drawing.Size(104, 24);
            this.lbEmployee.TabIndex = 11;
            this.lbEmployee.Text = "Employee";
            // 
            // lbCustomer
            // 
            this.lbCustomer.AutoSize = true;
            this.lbCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCustomer.Location = new System.Drawing.Point(23, 17);
            this.lbCustomer.Name = "lbCustomer";
            this.lbCustomer.Size = new System.Drawing.Size(99, 24);
            this.lbCustomer.TabIndex = 10;
            this.lbCustomer.Text = "Customer";
            // 
            // cbCustomer
            // 
            this.cbCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(143, 19);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(167, 26);
            this.cbCustomer.TabIndex = 8;
            // 
            // cbEmployee
            // 
            this.cbEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEmployee.FormattingEnabled = true;
            this.cbEmployee.Location = new System.Drawing.Point(143, 67);
            this.cbEmployee.Name = "cbEmployee";
            this.cbEmployee.Size = new System.Drawing.Size(167, 26);
            this.cbEmployee.TabIndex = 9;
            // 
            // cbShipper
            // 
            this.cbShipper.FormattingEnabled = true;
            this.cbShipper.Location = new System.Drawing.Point(615, 19);
            this.cbShipper.Name = "cbShipper";
            this.cbShipper.Size = new System.Drawing.Size(174, 24);
            this.cbShipper.TabIndex = 0;
            // 
            // pnButtom
            // 
            this.pnButtom.BackColor = System.Drawing.Color.Beige;
            this.pnButtom.Controls.Add(this.btnAdd);
            this.pnButtom.Controls.Add(this.pnButtonRight);
            this.pnButtom.Controls.Add(this.pnButtonLeft);
            this.pnButtom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnButtom.Location = new System.Drawing.Point(0, 117);
            this.pnButtom.Name = "pnButtom";
            this.pnButtom.Size = new System.Drawing.Size(955, 423);
            this.pnButtom.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(325, 157);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 29);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pnButtonRight
            // 
            this.pnButtonRight.Controls.Add(this.flowLayoutPanel);
            this.pnButtonRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnButtonRight.Location = new System.Drawing.Point(406, 0);
            this.pnButtonRight.Name = "pnButtonRight";
            this.pnButtonRight.Size = new System.Drawing.Size(549, 423);
            this.pnButtonRight.TabIndex = 3;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(549, 423);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // pnButtonLeft
            // 
            this.pnButtonLeft.Controls.Add(this.lbProducts);
            this.pnButtonLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnButtonLeft.Location = new System.Drawing.Point(0, 0);
            this.pnButtonLeft.Name = "pnButtonLeft";
            this.pnButtonLeft.Size = new System.Drawing.Size(319, 423);
            this.pnButtonLeft.TabIndex = 2;
            // 
            // lbProducts
            // 
            this.lbProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProducts.FormattingEnabled = true;
            this.lbProducts.ItemHeight = 22;
            this.lbProducts.Location = new System.Drawing.Point(0, 0);
            this.lbProducts.Name = "lbProducts";
            this.lbProducts.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbProducts.Size = new System.Drawing.Size(319, 423);
            this.lbProducts.TabIndex = 0;
            // 
            // AddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 540);
            this.Controls.Add(this.pnButtom);
            this.Controls.Add(this.pnTop);
            this.Name = "AddOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddOrder";
            this.Load += new System.EventHandler(this.AddOrder_Load);
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            this.pnButtom.ResumeLayout(false);
            this.pnButtonRight.ResumeLayout(false);
            this.pnButtonLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Panel pnButtom;
        private System.Windows.Forms.Panel pnButtonLeft;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel pnButtonRight;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.ComboBox cbShipper;
        private System.Windows.Forms.Label lbShiper;
        private System.Windows.Forms.Label lbEmployee;
        private System.Windows.Forms.Label lbCustomer;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.ComboBox cbEmployee;
        private System.Windows.Forms.Label lbRequireDate;
        private System.Windows.Forms.DateTimePicker dtpRequiredDate;
        private System.Windows.Forms.ListBox lbProducts;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
    }
}