namespace CustomerSaleSYS
{
    partial class DeleteProduct
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
            this.labelProductId = new System.Windows.Forms.Label();
            this.textProductId = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonSearchProduct = new System.Windows.Forms.Button();
            this.labelSearchProduct = new System.Windows.Forms.Label();
            this.textSearchProduct = new System.Windows.Forms.TextBox();
            this.buttonCloseForm = new System.Windows.Forms.Button();
            this.buttonDeleteProduct = new System.Windows.Forms.Button();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textQuantity = new System.Windows.Forms.TextBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelProductId
            // 
            this.labelProductId.AutoSize = true;
            this.labelProductId.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProductId.Location = new System.Drawing.Point(510, 158);
            this.labelProductId.Name = "labelProductId";
            this.labelProductId.Size = new System.Drawing.Size(39, 16);
            this.labelProductId.TabIndex = 47;
            this.labelProductId.Text = "ID: ";
            this.labelProductId.Visible = false;
            // 
            // textProductId
            // 
            this.textProductId.Location = new System.Drawing.Point(555, 158);
            this.textProductId.Name = "textProductId";
            this.textProductId.ReadOnly = true;
            this.textProductId.Size = new System.Drawing.Size(191, 20);
            this.textProductId.TabIndex = 46;
            this.textProductId.Text = "5";
            this.textProductId.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "ID:1, Name:Product1, Quantity:100, Price:30.20",
            "ID:2, Name:Product2, Quantity:12, Price:10.00",
            "ID:3, Name:Product3, Quantity:20, Price:150.00",
            "ID:4, Name:Product4, Quantity:40, Price:31.99",
            "ID:5, Name:Product5, Quantity:2, Price:3.30"});
            this.listBox1.Location = new System.Drawing.Point(36, 158);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(416, 228);
            this.listBox1.TabIndex = 45;
            // 
            // buttonSearchProduct
            // 
            this.buttonSearchProduct.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearchProduct.Location = new System.Drawing.Point(335, 74);
            this.buttonSearchProduct.Name = "buttonSearchProduct";
            this.buttonSearchProduct.Size = new System.Drawing.Size(117, 23);
            this.buttonSearchProduct.TabIndex = 44;
            this.buttonSearchProduct.Text = "Search";
            this.buttonSearchProduct.UseVisualStyleBackColor = true;
            this.buttonSearchProduct.Click += new System.EventHandler(this.buttonSearchProduct_Click);
            // 
            // labelSearchProduct
            // 
            this.labelSearchProduct.AutoSize = true;
            this.labelSearchProduct.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSearchProduct.Location = new System.Drawing.Point(33, 77);
            this.labelSearchProduct.Name = "labelSearchProduct";
            this.labelSearchProduct.Size = new System.Drawing.Size(71, 16);
            this.labelSearchProduct.TabIndex = 43;
            this.labelSearchProduct.Text = "Search: ";
            // 
            // textSearchProduct
            // 
            this.textSearchProduct.Location = new System.Drawing.Point(110, 77);
            this.textSearchProduct.Name = "textSearchProduct";
            this.textSearchProduct.Size = new System.Drawing.Size(191, 20);
            this.textSearchProduct.TabIndex = 42;
            // 
            // buttonCloseForm
            // 
            this.buttonCloseForm.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCloseForm.Location = new System.Drawing.Point(654, 17);
            this.buttonCloseForm.Name = "buttonCloseForm";
            this.buttonCloseForm.Size = new System.Drawing.Size(117, 23);
            this.buttonCloseForm.TabIndex = 41;
            this.buttonCloseForm.Text = "Close Form";
            this.buttonCloseForm.UseVisualStyleBackColor = true;
            this.buttonCloseForm.Click += new System.EventHandler(this.buttonCloseForm_Click);
            // 
            // buttonDeleteProduct
            // 
            this.buttonDeleteProduct.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteProduct.Location = new System.Drawing.Point(594, 378);
            this.buttonDeleteProduct.Name = "buttonDeleteProduct";
            this.buttonDeleteProduct.Size = new System.Drawing.Size(117, 23);
            this.buttonDeleteProduct.TabIndex = 40;
            this.buttonDeleteProduct.Text = "Delete Product";
            this.buttonDeleteProduct.UseVisualStyleBackColor = true;
            this.buttonDeleteProduct.Visible = false;
            this.buttonDeleteProduct.Click += new System.EventHandler(this.buttonDeleteProduct_Click);
            // 
            // textPrice
            // 
            this.textPrice.Location = new System.Drawing.Point(555, 317);
            this.textPrice.Name = "textPrice";
            this.textPrice.ReadOnly = true;
            this.textPrice.Size = new System.Drawing.Size(191, 20);
            this.textPrice.TabIndex = 39;
            this.textPrice.Text = "3.30";
            this.textPrice.Visible = false;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.Location = new System.Drawing.Point(494, 317);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(55, 16);
            this.labelPrice.TabIndex = 38;
            this.labelPrice.Text = "Price:";
            this.labelPrice.Visible = false;
            // 
            // textQuantity
            // 
            this.textQuantity.Location = new System.Drawing.Point(555, 261);
            this.textQuantity.Name = "textQuantity";
            this.textQuantity.ReadOnly = true;
            this.textQuantity.Size = new System.Drawing.Size(191, 20);
            this.textQuantity.TabIndex = 37;
            this.textQuantity.Text = "2";
            this.textQuantity.Visible = false;
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQuantity.Location = new System.Drawing.Point(470, 261);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(79, 16);
            this.labelQuantity.TabIndex = 36;
            this.labelQuantity.Text = "Quantity:";
            this.labelQuantity.Visible = false;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(496, 207);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(55, 16);
            this.labelName.TabIndex = 35;
            this.labelName.Text = "Name: ";
            this.labelName.Visible = false;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(555, 207);
            this.textName.Name = "textName";
            this.textName.ReadOnly = true;
            this.textName.Size = new System.Drawing.Size(191, 20);
            this.textName.TabIndex = 34;
            this.textName.Text = "Product5";
            this.textName.Visible = false;
            // 
            // DeleteProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.labelProductId);
            this.Controls.Add(this.textProductId);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonSearchProduct);
            this.Controls.Add(this.labelSearchProduct);
            this.Controls.Add(this.textSearchProduct);
            this.Controls.Add(this.buttonCloseForm);
            this.Controls.Add(this.buttonDeleteProduct);
            this.Controls.Add(this.textPrice);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.textQuantity);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textName);
            this.Name = "DeleteProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteProduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProductId;
        private System.Windows.Forms.TextBox textProductId;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonSearchProduct;
        private System.Windows.Forms.Label labelSearchProduct;
        private System.Windows.Forms.TextBox textSearchProduct;
        private System.Windows.Forms.Button buttonCloseForm;
        private System.Windows.Forms.Button buttonDeleteProduct;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textQuantity;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textName;
    }
}