
namespace ShopManagement
{
    partial class ListOrder
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.cbEmployee = new System.Windows.Forms.ComboBox();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.cbLateOrder = new System.Windows.Forms.CheckBox();
            this.pnGridView = new System.Windows.Forms.Panel();
            this.pnTop = new System.Windows.Forms.Panel();
            this.btnCreateOrder = new System.Windows.Forms.Button();
            this.lbTo = new System.Windows.Forms.Label();
            this.lbFrom = new System.Windows.Forms.Label();
            this.lbEmployee = new System.Windows.Forms.Label();
            this.lbCustomer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.pnGridView.SuspendLayout();
            this.pnTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1004, 518);
            this.dataGridView.TabIndex = 0;
            // 
            // cbCustomer
            // 
            this.cbCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(154, 26);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(167, 26);
            this.cbCustomer.TabIndex = 1;
            this.cbCustomer.SelectedIndexChanged += new System.EventHandler(this.cbCustomer_SelectedIndexChanged);
            // 
            // cbEmployee
            // 
            this.cbEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEmployee.FormattingEnabled = true;
            this.cbEmployee.Location = new System.Drawing.Point(154, 74);
            this.cbEmployee.Name = "cbEmployee";
            this.cbEmployee.Size = new System.Drawing.Size(167, 26);
            this.cbEmployee.TabIndex = 2;
            this.cbEmployee.SelectedIndexChanged += new System.EventHandler(this.cbEmployee_SelectedIndexChanged);
            // 
            // dtpFrom
            // 
            this.dtpFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFrom.Location = new System.Drawing.Point(501, 24);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(278, 24);
            this.dtpFrom.TabIndex = 3;
            this.dtpFrom.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
            // 
            // dtpTo
            // 
            this.dtpTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTo.Location = new System.Drawing.Point(501, 72);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(278, 24);
            this.dtpTo.TabIndex = 4;
            this.dtpTo.ValueChanged += new System.EventHandler(this.dtpTo_ValueChanged);
            // 
            // cbLateOrder
            // 
            this.cbLateOrder.AutoSize = true;
            this.cbLateOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLateOrder.Location = new System.Drawing.Point(154, 117);
            this.cbLateOrder.Name = "cbLateOrder";
            this.cbLateOrder.Size = new System.Drawing.Size(122, 24);
            this.cbLateOrder.TabIndex = 5;
            this.cbLateOrder.Text = "Late Order";
            this.cbLateOrder.UseVisualStyleBackColor = true;
            this.cbLateOrder.CheckedChanged += new System.EventHandler(this.cbLateOrder_CheckedChanged);
            // 
            // pnGridView
            // 
            this.pnGridView.Controls.Add(this.dataGridView);
            this.pnGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnGridView.Location = new System.Drawing.Point(0, 156);
            this.pnGridView.Name = "pnGridView";
            this.pnGridView.Size = new System.Drawing.Size(1004, 518);
            this.pnGridView.TabIndex = 6;
            // 
            // pnTop
            // 
            this.pnTop.Controls.Add(this.btnCreateOrder);
            this.pnTop.Controls.Add(this.lbTo);
            this.pnTop.Controls.Add(this.lbFrom);
            this.pnTop.Controls.Add(this.lbEmployee);
            this.pnTop.Controls.Add(this.lbCustomer);
            this.pnTop.Controls.Add(this.cbLateOrder);
            this.pnTop.Controls.Add(this.cbCustomer);
            this.pnTop.Controls.Add(this.dtpFrom);
            this.pnTop.Controls.Add(this.dtpTo);
            this.pnTop.Controls.Add(this.cbEmployee);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(1004, 156);
            this.pnTop.TabIndex = 7;
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.BackColor = System.Drawing.Color.ForestGreen;
            this.btnCreateOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateOrder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCreateOrder.Location = new System.Drawing.Point(819, 26);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(123, 70);
            this.btnCreateOrder.TabIndex = 10;
            this.btnCreateOrder.Text = "Create Order";
            this.btnCreateOrder.UseVisualStyleBackColor = false;
            this.btnCreateOrder.Click += new System.EventHandler(this.btnCreateOrder_Click);
            // 
            // lbTo
            // 
            this.lbTo.AutoSize = true;
            this.lbTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTo.Location = new System.Drawing.Point(370, 72);
            this.lbTo.Name = "lbTo";
            this.lbTo.Size = new System.Drawing.Size(83, 24);
            this.lbTo.TabIndex = 9;
            this.lbTo.Text = "Date To";
            // 
            // lbFrom
            // 
            this.lbFrom.AutoSize = true;
            this.lbFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFrom.Location = new System.Drawing.Point(370, 24);
            this.lbFrom.Name = "lbFrom";
            this.lbFrom.Size = new System.Drawing.Size(107, 24);
            this.lbFrom.TabIndex = 8;
            this.lbFrom.Text = "Date From";
            // 
            // lbEmployee
            // 
            this.lbEmployee.AutoSize = true;
            this.lbEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmployee.Location = new System.Drawing.Point(34, 72);
            this.lbEmployee.Name = "lbEmployee";
            this.lbEmployee.Size = new System.Drawing.Size(104, 24);
            this.lbEmployee.TabIndex = 7;
            this.lbEmployee.Text = "Employee";
            // 
            // lbCustomer
            // 
            this.lbCustomer.AutoSize = true;
            this.lbCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCustomer.Location = new System.Drawing.Point(34, 24);
            this.lbCustomer.Name = "lbCustomer";
            this.lbCustomer.Size = new System.Drawing.Size(99, 24);
            this.lbCustomer.TabIndex = 6;
            this.lbCustomer.Text = "Customer";
            // 
            // ListOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 674);
            this.Controls.Add(this.pnTop);
            this.Controls.Add(this.pnGridView);
            this.Name = "ListOrder";
            this.Text = "List Order";
            this.Load += new System.EventHandler(this.ListOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.pnGridView.ResumeLayout(false);
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.ComboBox cbEmployee;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.CheckBox cbLateOrder;
        private System.Windows.Forms.Panel pnGridView;
        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Label lbEmployee;
        private System.Windows.Forms.Label lbCustomer;
        private System.Windows.Forms.Label lbTo;
        private System.Windows.Forms.Label lbFrom;
        private System.Windows.Forms.Button btnCreateOrder;
    }
}

