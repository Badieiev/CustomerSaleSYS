namespace CustomerSaleSYS
{
    partial class AddProduct
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
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textQuantity = new System.Windows.Forms.TextBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonCloseForm
            // 
            this.buttonCloseForm.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCloseForm.Location = new System.Drawing.Point(355, 12);
            this.buttonCloseForm.Name = "buttonCloseForm";
            this.buttonCloseForm.Size = new System.Drawing.Size(117, 23);
            this.buttonCloseForm.TabIndex = 19;
            this.buttonCloseForm.Text = "Close Form";
            this.buttonCloseForm.UseVisualStyleBackColor = true;
            this.buttonCloseForm.Click += new System.EventHandler(this.buttonCloseForm_Click);
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddProduct.Location = new System.Drawing.Point(203, 301);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(117, 23);
            this.buttonAddProduct.TabIndex = 18;
            this.buttonAddProduct.Text = "Add Product";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // textPrice
            // 
            this.textPrice.Location = new System.Drawing.Point(164, 240);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(191, 20);
            this.textPrice.TabIndex = 15;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.Location = new System.Drawing.Point(103, 240);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(55, 16);
            this.labelPrice.TabIndex = 14;
            this.labelPrice.Text = "Price:";
            // 
            // textQuantity
            // 
            this.textQuantity.Location = new System.Drawing.Point(164, 184);
            this.textQuantity.Name = "textQuantity";
            this.textQuantity.Size = new System.Drawing.Size(191, 20);
            this.textQuantity.TabIndex = 13;
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQuantity.Location = new System.Drawing.Point(79, 184);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(79, 16);
            this.labelQuantity.TabIndex = 12;
            this.labelQuantity.Text = "Quantity:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(105, 130);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(55, 16);
            this.labelName.TabIndex = 11;
            this.labelName.Text = "Name: ";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(164, 130);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(191, 20);
            this.textName.TabIndex = 10;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.buttonCloseForm);
            this.Controls.Add(this.buttonAddProduct);
            this.Controls.Add(this.textPrice);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.textQuantity);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textName);
            this.Name = "AddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddProduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCloseForm;
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textQuantity;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textName;
    }
}