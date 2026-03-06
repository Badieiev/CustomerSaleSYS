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
            this.buttonCloseForm = new System.Windows.Forms.Button();
            this.buttonDeleteProduct = new System.Windows.Forms.Button();
            this.buttonSearchProduct = new System.Windows.Forms.Button();
            this.labelSearchProduct = new System.Windows.Forms.Label();
            this.textSearchProduct = new System.Windows.Forms.TextBox();
            this.grdProducts = new System.Windows.Forms.DataGridView();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textQuantity = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.labelProductId = new System.Windows.Forms.Label();
            this.textProductId = new System.Windows.Forms.TextBox();
            this.grpProduct = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdProducts)).BeginInit();
            this.grpProduct.SuspendLayout();
            this.SuspendLayout();
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
            this.buttonDeleteProduct.Location = new System.Drawing.Point(164, 245);
            this.buttonDeleteProduct.Name = "buttonDeleteProduct";
            this.buttonDeleteProduct.Size = new System.Drawing.Size(117, 23);
            this.buttonDeleteProduct.TabIndex = 40;
            this.buttonDeleteProduct.Text = "Delete Product";
            this.buttonDeleteProduct.UseVisualStyleBackColor = true;
            this.buttonDeleteProduct.Click += new System.EventHandler(this.buttonDeleteProduct_Click);
            // 
            // buttonSearchProduct
            // 
            this.buttonSearchProduct.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearchProduct.Location = new System.Drawing.Point(504, 69);
            this.buttonSearchProduct.Name = "buttonSearchProduct";
            this.buttonSearchProduct.Size = new System.Drawing.Size(117, 23);
            this.buttonSearchProduct.TabIndex = 50;
            this.buttonSearchProduct.Text = "Search";
            this.buttonSearchProduct.UseVisualStyleBackColor = true;
            this.buttonSearchProduct.Click += new System.EventHandler(this.buttonSearchProduct_Click);
            // 
            // labelSearchProduct
            // 
            this.labelSearchProduct.AutoSize = true;
            this.labelSearchProduct.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSearchProduct.Location = new System.Drawing.Point(23, 73);
            this.labelSearchProduct.Name = "labelSearchProduct";
            this.labelSearchProduct.Size = new System.Drawing.Size(279, 16);
            this.labelSearchProduct.TabIndex = 49;
            this.labelSearchProduct.Text = "Enter product name or part of data";
            // 
            // textSearchProduct
            // 
            this.textSearchProduct.Location = new System.Drawing.Point(308, 71);
            this.textSearchProduct.Name = "textSearchProduct";
            this.textSearchProduct.Size = new System.Drawing.Size(190, 20);
            this.textSearchProduct.TabIndex = 48;
            // 
            // grdProducts
            // 
            this.grdProducts.AllowUserToAddRows = false;
            this.grdProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProducts.Location = new System.Drawing.Point(26, 145);
            this.grdProducts.Name = "grdProducts";
            this.grdProducts.Size = new System.Drawing.Size(450, 280);
            this.grdProducts.TabIndex = 51;
            this.grdProducts.Visible = false;
            this.grdProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdProductsCellClick);
            // 
            // textPrice
            // 
            this.textPrice.Location = new System.Drawing.Point(91, 199);
            this.textPrice.Name = "textPrice";
            this.textPrice.ReadOnly = true;
            this.textPrice.Size = new System.Drawing.Size(190, 20);
            this.textPrice.TabIndex = 57;
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQuantity.Location = new System.Drawing.Point(9, 146);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(79, 16);
            this.labelQuantity.TabIndex = 54;
            this.labelQuantity.Text = "Quantity:";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.Location = new System.Drawing.Point(30, 199);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(55, 16);
            this.labelPrice.TabIndex = 56;
            this.labelPrice.Text = "Price:";
            // 
            // textQuantity
            // 
            this.textQuantity.Location = new System.Drawing.Point(91, 144);
            this.textQuantity.Name = "textQuantity";
            this.textQuantity.ReadOnly = true;
            this.textQuantity.Size = new System.Drawing.Size(190, 20);
            this.textQuantity.TabIndex = 55;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(32, 90);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(55, 16);
            this.labelName.TabIndex = 53;
            this.labelName.Text = "Name: ";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(91, 90);
            this.textName.Name = "textName";
            this.textName.ReadOnly = true;
            this.textName.Size = new System.Drawing.Size(190, 20);
            this.textName.TabIndex = 52;
            // 
            // labelProductId
            // 
            this.labelProductId.AutoSize = true;
            this.labelProductId.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProductId.Location = new System.Drawing.Point(47, 40);
            this.labelProductId.Name = "labelProductId";
            this.labelProductId.Size = new System.Drawing.Size(39, 16);
            this.labelProductId.TabIndex = 59;
            this.labelProductId.Text = "ID: ";
            // 
            // textProductId
            // 
            this.textProductId.Location = new System.Drawing.Point(91, 38);
            this.textProductId.Name = "textProductId";
            this.textProductId.ReadOnly = true;
            this.textProductId.Size = new System.Drawing.Size(190, 20);
            this.textProductId.TabIndex = 58;
            // 
            // grpProduct
            // 
            this.grpProduct.Controls.Add(this.labelProductId);
            this.grpProduct.Controls.Add(this.textProductId);
            this.grpProduct.Controls.Add(this.textPrice);
            this.grpProduct.Controls.Add(this.labelQuantity);
            this.grpProduct.Controls.Add(this.labelPrice);
            this.grpProduct.Controls.Add(this.textQuantity);
            this.grpProduct.Controls.Add(this.labelName);
            this.grpProduct.Controls.Add(this.textName);
            this.grpProduct.Controls.Add(this.buttonDeleteProduct);
            this.grpProduct.Location = new System.Drawing.Point(482, 145);
            this.grpProduct.Name = "grpProduct";
            this.grpProduct.Size = new System.Drawing.Size(290, 280);
            this.grpProduct.TabIndex = 60;
            this.grpProduct.TabStop = false;
            this.grpProduct.Text = "Delete Product Details";
            this.grpProduct.Visible = false;
            // 
            // DeleteProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.grpProduct);
            this.Controls.Add(this.grdProducts);
            this.Controls.Add(this.buttonSearchProduct);
            this.Controls.Add(this.labelSearchProduct);
            this.Controls.Add(this.textSearchProduct);
            this.Controls.Add(this.buttonCloseForm);
            this.Name = "DeleteProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteProduct";
            ((System.ComponentModel.ISupportInitialize)(this.grdProducts)).EndInit();
            this.grpProduct.ResumeLayout(false);
            this.grpProduct.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonCloseForm;
        private System.Windows.Forms.Button buttonDeleteProduct;
        private System.Windows.Forms.Button buttonSearchProduct;
        private System.Windows.Forms.Label labelSearchProduct;
        private System.Windows.Forms.TextBox textSearchProduct;
        private System.Windows.Forms.DataGridView grdProducts;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textQuantity;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label labelProductId;
        private System.Windows.Forms.TextBox textProductId;
        private System.Windows.Forms.GroupBox grpProduct;
    }
}