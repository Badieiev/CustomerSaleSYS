namespace CustomerSaleSYS
{
    partial class CreateOrder
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
            this.buttonCloseForm = new System.Windows.Forms.Button();
            this.buttonCreateOrder = new System.Windows.Forms.Button();
            this.labelDate = new System.Windows.Forms.Label();
            this.textQuantity = new System.Windows.Forms.TextBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboProduct = new System.Windows.Forms.ComboBox();
            this.comboCustomer = new System.Windows.Forms.ComboBox();
            this.labelCustomer = new System.Windows.Forms.Label();
            this.labelProduct = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCloseForm
            // 
            this.buttonCloseForm.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCloseForm.Location = new System.Drawing.Point(355, 12);
            this.buttonCloseForm.Name = "buttonCloseForm";
            this.buttonCloseForm.Size = new System.Drawing.Size(117, 23);
            this.buttonCloseForm.TabIndex = 27;
            this.buttonCloseForm.Text = "Close Form";
            this.buttonCloseForm.UseVisualStyleBackColor = true;
            this.buttonCloseForm.Click += new System.EventHandler(this.buttonCloseForm_Click);
            // 
            // buttonCreateOrder
            // 
            this.buttonCreateOrder.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreateOrder.Location = new System.Drawing.Point(198, 365);
            this.buttonCreateOrder.Name = "buttonCreateOrder";
            this.buttonCreateOrder.Size = new System.Drawing.Size(117, 23);
            this.buttonCreateOrder.TabIndex = 26;
            this.buttonCreateOrder.Text = "Create Order";
            this.buttonCreateOrder.UseVisualStyleBackColor = true;
            this.buttonCreateOrder.Click += new System.EventHandler(this.buttonCreateOrder_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDate.Location = new System.Drawing.Point(106, 304);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(47, 16);
            this.labelDate.TabIndex = 24;
            this.labelDate.Text = "Date:";
            // 
            // textQuantity
            // 
            this.textQuantity.Location = new System.Drawing.Point(159, 248);
            this.textQuantity.Name = "textQuantity";
            this.textQuantity.Size = new System.Drawing.Size(191, 20);
            this.textQuantity.TabIndex = 23;
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQuantity.Location = new System.Drawing.Point(74, 248);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(79, 16);
            this.labelQuantity.TabIndex = 22;
            this.labelQuantity.Text = "Quantity:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(159, 300);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(191, 20);
            this.dateTimePicker1.TabIndex = 28;
            // 
            // comboProduct
            // 
            this.comboProduct.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboProduct.FormattingEnabled = true;
            this.comboProduct.Items.AddRange(new object[] {
            "Product1",
            "Product2",
            "Product3",
            "Product4",
            "Product5"});
            this.comboProduct.Location = new System.Drawing.Point(159, 189);
            this.comboProduct.Name = "comboProduct";
            this.comboProduct.Size = new System.Drawing.Size(191, 24);
            this.comboProduct.TabIndex = 30;
            // 
            // comboCustomer
            // 
            this.comboCustomer.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboCustomer.FormattingEnabled = true;
            this.comboCustomer.Items.AddRange(new object[] {
            "Sullivan",
            "Brady",
            "Kelly",
            "Brennan",
            "Murphy"});
            this.comboCustomer.Location = new System.Drawing.Point(159, 131);
            this.comboCustomer.Name = "comboCustomer";
            this.comboCustomer.Size = new System.Drawing.Size(191, 24);
            this.comboCustomer.TabIndex = 31;
            // 
            // labelCustomer
            // 
            this.labelCustomer.AutoSize = true;
            this.labelCustomer.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCustomer.Location = new System.Drawing.Point(74, 134);
            this.labelCustomer.Name = "labelCustomer";
            this.labelCustomer.Size = new System.Drawing.Size(79, 16);
            this.labelCustomer.TabIndex = 32;
            this.labelCustomer.Text = "Customer:";
            // 
            // labelProduct
            // 
            this.labelProduct.AutoSize = true;
            this.labelProduct.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProduct.Location = new System.Drawing.Point(82, 192);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(71, 16);
            this.labelProduct.TabIndex = 33;
            this.labelProduct.Text = "Product:";
            // 
            // CreateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.labelProduct);
            this.Controls.Add(this.labelCustomer);
            this.Controls.Add(this.comboCustomer);
            this.Controls.Add(this.comboProduct);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.buttonCloseForm);
            this.Controls.Add(this.buttonCreateOrder);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.textQuantity);
            this.Controls.Add(this.labelQuantity);
            this.Name = "CreateOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateOrder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCloseForm;
        private System.Windows.Forms.Button buttonCreateOrder;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.TextBox textQuantity;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboProduct;
        private System.Windows.Forms.ComboBox comboCustomer;
        private System.Windows.Forms.Label labelCustomer;
        private System.Windows.Forms.Label labelProduct;
    }
}