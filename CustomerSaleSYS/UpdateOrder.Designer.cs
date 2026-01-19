namespace CustomerSaleSYS
{
    partial class UpdateOrder
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
            this.labelProduct = new System.Windows.Forms.Label();
            this.labelCustomer = new System.Windows.Forms.Label();
            this.comboCustomer = new System.Windows.Forms.ComboBox();
            this.comboProduct = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonCloseForm = new System.Windows.Forms.Button();
            this.buttonUpdateOrder = new System.Windows.Forms.Button();
            this.labelDate = new System.Windows.Forms.Label();
            this.textQuantity = new System.Windows.Forms.TextBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.listBoxOrder = new System.Windows.Forms.ListBox();
            this.buttonSearchCustomer = new System.Windows.Forms.Button();
            this.labelSearchCustomer = new System.Windows.Forms.Label();
            this.textSearchCustomer = new System.Windows.Forms.TextBox();
            this.labelProductId = new System.Windows.Forms.Label();
            this.textProductId = new System.Windows.Forms.TextBox();
            this.textSum = new System.Windows.Forms.TextBox();
            this.labelSum = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelProduct
            // 
            this.labelProduct.AutoSize = true;
            this.labelProduct.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProduct.Location = new System.Drawing.Point(518, 163);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(71, 16);
            this.labelProduct.TabIndex = 43;
            this.labelProduct.Text = "Product:";
            this.labelProduct.Visible = false;
            // 
            // labelCustomer
            // 
            this.labelCustomer.AutoSize = true;
            this.labelCustomer.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCustomer.Location = new System.Drawing.Point(510, 112);
            this.labelCustomer.Name = "labelCustomer";
            this.labelCustomer.Size = new System.Drawing.Size(79, 16);
            this.labelCustomer.TabIndex = 42;
            this.labelCustomer.Text = "Customer:";
            this.labelCustomer.Visible = false;
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
            this.comboCustomer.Location = new System.Drawing.Point(595, 109);
            this.comboCustomer.Name = "comboCustomer";
            this.comboCustomer.Size = new System.Drawing.Size(191, 24);
            this.comboCustomer.TabIndex = 41;
            this.comboCustomer.Text = "Roisin";
            this.comboCustomer.Visible = false;
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
            this.comboProduct.Location = new System.Drawing.Point(595, 160);
            this.comboProduct.Name = "comboProduct";
            this.comboProduct.Size = new System.Drawing.Size(191, 24);
            this.comboProduct.TabIndex = 40;
            this.comboProduct.Text = "Product5";
            this.comboProduct.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(595, 261);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(191, 20);
            this.dateTimePicker1.TabIndex = 39;
            this.dateTimePicker1.Visible = false;
            // 
            // buttonCloseForm
            // 
            this.buttonCloseForm.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCloseForm.Location = new System.Drawing.Point(671, 12);
            this.buttonCloseForm.Name = "buttonCloseForm";
            this.buttonCloseForm.Size = new System.Drawing.Size(117, 23);
            this.buttonCloseForm.TabIndex = 38;
            this.buttonCloseForm.Text = "Close Form";
            this.buttonCloseForm.UseVisualStyleBackColor = true;
            this.buttonCloseForm.Click += new System.EventHandler(this.buttonCloseForm_Click);
            // 
            // buttonUpdateOrder
            // 
            this.buttonUpdateOrder.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpdateOrder.Location = new System.Drawing.Point(633, 403);
            this.buttonUpdateOrder.Name = "buttonUpdateOrder";
            this.buttonUpdateOrder.Size = new System.Drawing.Size(117, 23);
            this.buttonUpdateOrder.TabIndex = 37;
            this.buttonUpdateOrder.Text = "Update Order";
            this.buttonUpdateOrder.UseVisualStyleBackColor = true;
            this.buttonUpdateOrder.Visible = false;
            this.buttonUpdateOrder.Click += new System.EventHandler(this.buttonUpdateOrder_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDate.Location = new System.Drawing.Point(542, 265);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(47, 16);
            this.labelDate.TabIndex = 36;
            this.labelDate.Text = "Date:";
            this.labelDate.Visible = false;
            // 
            // textQuantity
            // 
            this.textQuantity.Location = new System.Drawing.Point(595, 211);
            this.textQuantity.Name = "textQuantity";
            this.textQuantity.Size = new System.Drawing.Size(191, 20);
            this.textQuantity.TabIndex = 35;
            this.textQuantity.Text = "1";
            this.textQuantity.Visible = false;
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQuantity.Location = new System.Drawing.Point(510, 211);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(79, 16);
            this.labelQuantity.TabIndex = 34;
            this.labelQuantity.Text = "Quantity:";
            this.labelQuantity.Visible = false;
            // 
            // listBoxOrder
            // 
            this.listBoxOrder.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxOrder.FormattingEnabled = true;
            this.listBoxOrder.HorizontalScrollbar = true;
            this.listBoxOrder.ItemHeight = 16;
            this.listBoxOrder.Items.AddRange(new object[] {
            "ID:1, Customer:Brady, Product:Product2, Quantity:2, Date:04-12-2025, Sum:20.00, S" +
                "tatus:F",
            "ID:2, Customer:Kelly, Product:Product3, Quantity:10, Date:04-12-2025, Sum:1500.00" +
                ", Status:N",
            "ID:3, Customer:Roisin, Product:Product5, Quantity:1, Date:04-12-2025, Sum:3.30, S" +
                "tatus:N"});
            this.listBoxOrder.Location = new System.Drawing.Point(15, 142);
            this.listBoxOrder.Name = "listBoxOrder";
            this.listBoxOrder.Size = new System.Drawing.Size(489, 228);
            this.listBoxOrder.TabIndex = 47;
            // 
            // buttonSearchCustomer
            // 
            this.buttonSearchCustomer.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearchCustomer.Location = new System.Drawing.Point(387, 65);
            this.buttonSearchCustomer.Name = "buttonSearchCustomer";
            this.buttonSearchCustomer.Size = new System.Drawing.Size(117, 23);
            this.buttonSearchCustomer.TabIndex = 46;
            this.buttonSearchCustomer.Text = "Search";
            this.buttonSearchCustomer.UseVisualStyleBackColor = true;
            this.buttonSearchCustomer.Click += new System.EventHandler(this.buttonSearchCustomer_Click);
            // 
            // labelSearchCustomer
            // 
            this.labelSearchCustomer.AutoSize = true;
            this.labelSearchCustomer.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSearchCustomer.Location = new System.Drawing.Point(101, 69);
            this.labelSearchCustomer.Name = "labelSearchCustomer";
            this.labelSearchCustomer.Size = new System.Drawing.Size(71, 16);
            this.labelSearchCustomer.TabIndex = 45;
            this.labelSearchCustomer.Text = "Search: ";
            // 
            // textSearchCustomer
            // 
            this.textSearchCustomer.Location = new System.Drawing.Point(178, 67);
            this.textSearchCustomer.Name = "textSearchCustomer";
            this.textSearchCustomer.Size = new System.Drawing.Size(191, 20);
            this.textSearchCustomer.TabIndex = 44;
            // 
            // labelProductId
            // 
            this.labelProductId.AutoSize = true;
            this.labelProductId.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProductId.Location = new System.Drawing.Point(550, 67);
            this.labelProductId.Name = "labelProductId";
            this.labelProductId.Size = new System.Drawing.Size(39, 16);
            this.labelProductId.TabIndex = 49;
            this.labelProductId.Text = "ID: ";
            this.labelProductId.Visible = false;
            // 
            // textProductId
            // 
            this.textProductId.Location = new System.Drawing.Point(595, 67);
            this.textProductId.Name = "textProductId";
            this.textProductId.ReadOnly = true;
            this.textProductId.Size = new System.Drawing.Size(191, 20);
            this.textProductId.TabIndex = 48;
            this.textProductId.Text = "3";
            this.textProductId.Visible = false;
            // 
            // textSum
            // 
            this.textSum.Location = new System.Drawing.Point(595, 312);
            this.textSum.Name = "textSum";
            this.textSum.ReadOnly = true;
            this.textSum.Size = new System.Drawing.Size(191, 20);
            this.textSum.TabIndex = 51;
            this.textSum.Text = "3.30";
            this.textSum.Visible = false;
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSum.Location = new System.Drawing.Point(534, 312);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(39, 16);
            this.labelSum.TabIndex = 50;
            this.labelSum.Text = "Sum:";
            this.labelSum.Visible = false;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStatus.Location = new System.Drawing.Point(526, 361);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(63, 16);
            this.labelStatus.TabIndex = 52;
            this.labelStatus.Text = "Status:";
            this.labelStatus.Visible = false;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "N",
            "F"});
            this.comboBoxStatus.Location = new System.Drawing.Point(595, 358);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(191, 24);
            this.comboBoxStatus.TabIndex = 53;
            this.comboBoxStatus.Text = "N";
            this.comboBoxStatus.Visible = false;
            // 
            // UpdateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.textSum);
            this.Controls.Add(this.labelSum);
            this.Controls.Add(this.labelProductId);
            this.Controls.Add(this.textProductId);
            this.Controls.Add(this.listBoxOrder);
            this.Controls.Add(this.buttonSearchCustomer);
            this.Controls.Add(this.labelSearchCustomer);
            this.Controls.Add(this.textSearchCustomer);
            this.Controls.Add(this.labelProduct);
            this.Controls.Add(this.labelCustomer);
            this.Controls.Add(this.comboCustomer);
            this.Controls.Add(this.comboProduct);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.buttonCloseForm);
            this.Controls.Add(this.buttonUpdateOrder);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.textQuantity);
            this.Controls.Add(this.labelQuantity);
            this.Name = "UpdateOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateOrder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.Label labelCustomer;
        private System.Windows.Forms.ComboBox comboCustomer;
        private System.Windows.Forms.ComboBox comboProduct;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonCloseForm;
        private System.Windows.Forms.Button buttonUpdateOrder;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.TextBox textQuantity;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.ListBox listBoxOrder;
        private System.Windows.Forms.Button buttonSearchCustomer;
        private System.Windows.Forms.Label labelSearchCustomer;
        private System.Windows.Forms.TextBox textSearchCustomer;
        private System.Windows.Forms.Label labelProductId;
        private System.Windows.Forms.TextBox textProductId;
        private System.Windows.Forms.TextBox textSum;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ComboBox comboBoxStatus;
    }
}