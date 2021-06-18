
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
            this.pnButton = new System.Windows.Forms.Panel();
            this.pnButtonLeft = new System.Windows.Forms.Panel();
            this.pnButtonRight = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbEmployee = new System.Windows.Forms.Label();
            this.lbCustomer = new System.Windows.Forms.Label();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.cbEmployee = new System.Windows.Forms.ComboBox();
            this.lbShiper = new System.Windows.Forms.Label();
            this.lbRequireDate = new System.Windows.Forms.Label();
            this.dtpRequiredDate = new System.Windows.Forms.DateTimePicker();
            this.pnTop.SuspendLayout();
            this.pnButton.SuspendLayout();
            this.pnButtonRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.Controls.Add(this.lbRequireDate);
            this.pnTop.Controls.Add(this.dtpRequiredDate);
            this.pnTop.Controls.Add(this.lbShiper);
            this.pnTop.Controls.Add(this.lbEmployee);
            this.pnTop.Controls.Add(this.lbCustomer);
            this.pnTop.Controls.Add(this.cbCustomer);
            this.pnTop.Controls.Add(this.cbEmployee);
            this.pnTop.Controls.Add(this.comboBox1);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(800, 117);
            this.pnTop.TabIndex = 0;
            // 
            // pnButton
            // 
            this.pnButton.Controls.Add(this.btnAdd);
            this.pnButton.Controls.Add(this.pnButtonRight);
            this.pnButton.Controls.Add(this.pnButtonLeft);
            this.pnButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnButton.Location = new System.Drawing.Point(0, 117);
            this.pnButton.Name = "pnButton";
            this.pnButton.Size = new System.Drawing.Size(800, 408);
            this.pnButton.TabIndex = 1;
            // 
            // pnButtonLeft
            // 
            this.pnButtonLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnButtonLeft.Location = new System.Drawing.Point(0, 0);
            this.pnButtonLeft.Name = "pnButtonLeft";
            this.pnButtonLeft.Size = new System.Drawing.Size(319, 408);
            this.pnButtonLeft.TabIndex = 2;
            // 
            // pnButtonRight
            // 
            this.pnButtonRight.Controls.Add(this.btnCreate);
            this.pnButtonRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnButtonRight.Location = new System.Drawing.Point(406, 0);
            this.pnButtonRight.Name = "pnButtonRight";
            this.pnButtonRight.Size = new System.Drawing.Size(394, 408);
            this.pnButtonRight.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(325, 157);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 29);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(284, 349);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(98, 47);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(476, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 0;
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
            // lbShiper
            // 
            this.lbShiper.AutoSize = true;
            this.lbShiper.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShiper.Location = new System.Drawing.Point(371, 19);
            this.lbShiper.Name = "lbShiper";
            this.lbShiper.Size = new System.Drawing.Size(83, 24);
            this.lbShiper.TabIndex = 12;
            this.lbShiper.Text = "Shipper";
            // 
            // lbRequireDate
            // 
            this.lbRequireDate.AutoSize = true;
            this.lbRequireDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRequireDate.Location = new System.Drawing.Point(371, 65);
            this.lbRequireDate.Name = "lbRequireDate";
            this.lbRequireDate.Size = new System.Drawing.Size(132, 24);
            this.lbRequireDate.TabIndex = 14;
            this.lbRequireDate.Text = "Require Date";
            // 
            // dtpRequiredDate
            // 
            this.dtpRequiredDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpRequiredDate.Location = new System.Drawing.Point(509, 65);
            this.dtpRequiredDate.Name = "dtpRequiredDate";
            this.dtpRequiredDate.Size = new System.Drawing.Size(278, 24);
            this.dtpRequiredDate.TabIndex = 13;
            // 
            // AddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 525);
            this.Controls.Add(this.pnButton);
            this.Controls.Add(this.pnTop);
            this.Name = "AddOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddOrder";
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            this.pnButton.ResumeLayout(false);
            this.pnButtonRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Panel pnButton;
        private System.Windows.Forms.Panel pnButtonLeft;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel pnButtonRight;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbShiper;
        private System.Windows.Forms.Label lbEmployee;
        private System.Windows.Forms.Label lbCustomer;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.ComboBox cbEmployee;
        private System.Windows.Forms.Label lbRequireDate;
        private System.Windows.Forms.DateTimePicker dtpRequiredDate;
    }
}