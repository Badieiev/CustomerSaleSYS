namespace CustomerSaleSYS
{
    partial class DeleteOrder
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
            this.textSum = new System.Windows.Forms.TextBox();
            this.labelSum = new System.Windows.Forms.Label();
            this.labelProductId = new System.Windows.Forms.Label();
            this.textOrderId = new System.Windows.Forms.TextBox();
            this.buttonSearchCustomer = new System.Windows.Forms.Button();
            this.labelSearchCustomer = new System.Windows.Forms.Label();
            this.textSearchOrder = new System.Windows.Forms.TextBox();
            this.labelCustomer = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.buttonCloseForm = new System.Windows.Forms.Button();
            this.buttonDeleteOrder = new System.Windows.Forms.Button();
            this.labelDate = new System.Windows.Forms.Label();
            this.grdOrders = new System.Windows.Forms.DataGridView();
            this.textCustomer = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrders)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textSum
            // 
            this.textSum.Location = new System.Drawing.Point(574, 163);
            this.textSum.Name = "textSum";
            this.textSum.ReadOnly = true;
            this.textSum.Size = new System.Drawing.Size(191, 20);
            this.textSum.TabIndex = 71;
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSum.Location = new System.Drawing.Point(513, 163);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(39, 16);
            this.labelSum.TabIndex = 70;
            this.labelSum.Text = "Sum:";
            // 
            // labelProductId
            // 
            this.labelProductId.AutoSize = true;
            this.labelProductId.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProductId.Location = new System.Drawing.Point(529, 30);
            this.labelProductId.Name = "labelProductId";
            this.labelProductId.Size = new System.Drawing.Size(39, 16);
            this.labelProductId.TabIndex = 69;
            this.labelProductId.Text = "ID: ";
            // 
            // textOrderId
            // 
            this.textOrderId.Location = new System.Drawing.Point(574, 30);
            this.textOrderId.Name = "textOrderId";
            this.textOrderId.ReadOnly = true;
            this.textOrderId.Size = new System.Drawing.Size(191, 20);
            this.textOrderId.TabIndex = 68;
            // 
            // buttonSearchCustomer
            // 
            this.buttonSearchCustomer.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearchCustomer.Location = new System.Drawing.Point(347, 59);
            this.buttonSearchCustomer.Name = "buttonSearchCustomer";
            this.buttonSearchCustomer.Size = new System.Drawing.Size(117, 23);
            this.buttonSearchCustomer.TabIndex = 66;
            this.buttonSearchCustomer.Text = "Search";
            this.buttonSearchCustomer.UseVisualStyleBackColor = true;
            this.buttonSearchCustomer.Click += new System.EventHandler(this.ButtonSearchCustomer_Click);
            // 
            // labelSearchCustomer
            // 
            this.labelSearchCustomer.AutoSize = true;
            this.labelSearchCustomer.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSearchCustomer.Location = new System.Drawing.Point(9, 65);
            this.labelSearchCustomer.Name = "labelSearchCustomer";
            this.labelSearchCustomer.Size = new System.Drawing.Size(135, 16);
            this.labelSearchCustomer.TabIndex = 65;
            this.labelSearchCustomer.Text = "Enter Order ID: ";
            // 
            // textSearchOrder
            // 
            this.textSearchOrder.Location = new System.Drawing.Point(150, 61);
            this.textSearchOrder.Name = "textSearchOrder";
            this.textSearchOrder.Size = new System.Drawing.Size(191, 20);
            this.textSearchOrder.TabIndex = 64;
            // 
            // labelCustomer
            // 
            this.labelCustomer.AutoSize = true;
            this.labelCustomer.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCustomer.Location = new System.Drawing.Point(489, 75);
            this.labelCustomer.Name = "labelCustomer";
            this.labelCustomer.Size = new System.Drawing.Size(79, 16);
            this.labelCustomer.TabIndex = 62;
            this.labelCustomer.Text = "Customer:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Enabled = false;
            this.dateTimePicker.Location = new System.Drawing.Point(574, 118);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(191, 20);
            this.dateTimePicker.TabIndex = 59;
            // 
            // buttonCloseForm
            // 
            this.buttonCloseForm.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCloseForm.Location = new System.Drawing.Point(659, 13);
            this.buttonCloseForm.Name = "buttonCloseForm";
            this.buttonCloseForm.Size = new System.Drawing.Size(117, 23);
            this.buttonCloseForm.TabIndex = 58;
            this.buttonCloseForm.Text = "Close Form";
            this.buttonCloseForm.UseVisualStyleBackColor = true;
            this.buttonCloseForm.Click += new System.EventHandler(this.ButtonCloseForm_Click);
            // 
            // buttonDeleteOrder
            // 
            this.buttonDeleteOrder.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteOrder.Location = new System.Drawing.Point(648, 214);
            this.buttonDeleteOrder.Name = "buttonDeleteOrder";
            this.buttonDeleteOrder.Size = new System.Drawing.Size(117, 23);
            this.buttonDeleteOrder.TabIndex = 57;
            this.buttonDeleteOrder.Text = "Delete Order";
            this.buttonDeleteOrder.UseVisualStyleBackColor = true;
            this.buttonDeleteOrder.Click += new System.EventHandler(this.ButtonDeleteOrder_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDate.Location = new System.Drawing.Point(521, 122);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(47, 16);
            this.labelDate.TabIndex = 56;
            this.labelDate.Text = "Date:";
            // 
            // grdOrders
            // 
            this.grdOrders.AllowUserToAddRows = false;
            this.grdOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOrders.Location = new System.Drawing.Point(1, 19);
            this.grdOrders.Name = "grdOrders";
            this.grdOrders.Size = new System.Drawing.Size(450, 280);
            this.grdOrders.TabIndex = 74;
            this.grdOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdOrdersCellClick);
            // 
            // textCustomer
            // 
            this.textCustomer.Location = new System.Drawing.Point(574, 73);
            this.textCustomer.Name = "textCustomer";
            this.textCustomer.ReadOnly = true;
            this.textCustomer.Size = new System.Drawing.Size(191, 20);
            this.textCustomer.TabIndex = 75;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textCustomer);
            this.groupBox1.Controls.Add(this.grdOrders);
            this.groupBox1.Controls.Add(this.textSum);
            this.groupBox1.Controls.Add(this.labelSum);
            this.groupBox1.Controls.Add(this.labelProductId);
            this.groupBox1.Controls.Add(this.textOrderId);
            this.groupBox1.Controls.Add(this.labelCustomer);
            this.groupBox1.Controls.Add(this.dateTimePicker);
            this.groupBox1.Controls.Add(this.buttonDeleteOrder);
            this.groupBox1.Controls.Add(this.labelDate);
            this.groupBox1.Location = new System.Drawing.Point(11, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(772, 302);
            this.groupBox1.TabIndex = 76;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Details: Select the order you want to delete.";
            // 
            // DeleteOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSearchCustomer);
            this.Controls.Add(this.labelSearchCustomer);
            this.Controls.Add(this.textSearchOrder);
            this.Controls.Add(this.buttonCloseForm);
            this.Name = "DeleteOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteOrder";
            ((System.ComponentModel.ISupportInitialize)(this.grdOrders)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textSum;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.Label labelProductId;
        private System.Windows.Forms.TextBox textOrderId;
        private System.Windows.Forms.Button buttonSearchCustomer;
        private System.Windows.Forms.Label labelSearchCustomer;
        private System.Windows.Forms.TextBox textSearchOrder;
        private System.Windows.Forms.Label labelCustomer;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button buttonCloseForm;
        private System.Windows.Forms.Button buttonDeleteOrder;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DataGridView grdOrders;
        private System.Windows.Forms.TextBox textCustomer;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}