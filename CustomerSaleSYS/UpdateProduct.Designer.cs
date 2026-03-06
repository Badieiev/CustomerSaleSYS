namespace CustomerSaleSYS
{
    partial class UpdateProduct
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
            this.buttonUpdateProduct = new System.Windows.Forms.Button();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textQuantity = new System.Windows.Forms.TextBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.buttonSearchProduct = new System.Windows.Forms.Button();
            this.labelSearchProduct = new System.Windows.Forms.Label();
            this.textSearchProduct = new System.Windows.Forms.TextBox();
            this.grdProducts = new System.Windows.Forms.DataGridView();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.grpProduct = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdProducts)).BeginInit();
            this.grpProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCloseForm
            // 
            this.buttonCloseForm.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCloseForm.Location = new System.Drawing.Point(650, 11);
            this.buttonCloseForm.Name = "buttonCloseForm";
            this.buttonCloseForm.Size = new System.Drawing.Size(117, 23);
            this.buttonCloseForm.TabIndex = 27;
            this.buttonCloseForm.Text = "Close Form";
            this.buttonCloseForm.UseVisualStyleBackColor = true;
            this.buttonCloseForm.Click += new System.EventHandler(this.buttonCloseForm_Click);
            // 
            // buttonUpdateProduct
            // 
            this.buttonUpdateProduct.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpdateProduct.Location = new System.Drawing.Point(157, 251);
            this.buttonUpdateProduct.Name = "buttonUpdateProduct";
            this.buttonUpdateProduct.Size = new System.Drawing.Size(117, 23);
            this.buttonUpdateProduct.TabIndex = 26;
            this.buttonUpdateProduct.Text = "Update Product";
            this.buttonUpdateProduct.UseVisualStyleBackColor = true;
            this.buttonUpdateProduct.Click += new System.EventHandler(this.buttonUpdateProduct_Click);
            // 
            // textPrice
            // 
            this.textPrice.Location = new System.Drawing.Point(83, 150);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(190, 20);
            this.textPrice.TabIndex = 25;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.Location = new System.Drawing.Point(22, 150);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(55, 16);
            this.labelPrice.TabIndex = 24;
            this.labelPrice.Text = "Price:";
            // 
            // textQuantity
            // 
            this.textQuantity.Location = new System.Drawing.Point(83, 98);
            this.textQuantity.Name = "textQuantity";
            this.textQuantity.Size = new System.Drawing.Size(190, 20);
            this.textQuantity.TabIndex = 23;
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQuantity.Location = new System.Drawing.Point(1, 100);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(79, 16);
            this.labelQuantity.TabIndex = 22;
            this.labelQuantity.Text = "Quantity:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(24, 43);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(55, 16);
            this.labelName.TabIndex = 21;
            this.labelName.Text = "Name: ";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(83, 43);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(190, 20);
            this.textName.TabIndex = 20;
            // 
            // buttonSearchProduct
            // 
            this.buttonSearchProduct.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearchProduct.Location = new System.Drawing.Point(510, 67);
            this.buttonSearchProduct.Name = "buttonSearchProduct";
            this.buttonSearchProduct.Size = new System.Drawing.Size(117, 23);
            this.buttonSearchProduct.TabIndex = 30;
            this.buttonSearchProduct.Text = "Search";
            this.buttonSearchProduct.UseVisualStyleBackColor = true;
            this.buttonSearchProduct.Click += new System.EventHandler(this.buttonSearchProduct_Click);
            // 
            // labelSearchProduct
            // 
            this.labelSearchProduct.AutoSize = true;
            this.labelSearchProduct.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSearchProduct.Location = new System.Drawing.Point(29, 71);
            this.labelSearchProduct.Name = "labelSearchProduct";
            this.labelSearchProduct.Size = new System.Drawing.Size(279, 16);
            this.labelSearchProduct.TabIndex = 29;
            this.labelSearchProduct.Text = "Enter product name or part of data";
            // 
            // textSearchProduct
            // 
            this.textSearchProduct.Location = new System.Drawing.Point(314, 69);
            this.textSearchProduct.Name = "textSearchProduct";
            this.textSearchProduct.Size = new System.Drawing.Size(190, 20);
            this.textSearchProduct.TabIndex = 28;
            // 
            // grdProducts
            // 
            this.grdProducts.AllowUserToAddRows = false;
            this.grdProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProducts.Location = new System.Drawing.Point(32, 146);
            this.grdProducts.Name = "grdProducts";
            this.grdProducts.Size = new System.Drawing.Size(450, 280);
            this.grdProducts.TabIndex = 34;
            this.grdProducts.Visible = false;
            this.grdProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdProductsCellClick);
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "A",
            "I"});
            this.cboStatus.Location = new System.Drawing.Point(83, 198);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(121, 21);
            this.cboStatus.TabIndex = 36;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStatus.Location = new System.Drawing.Point(8, 200);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(71, 16);
            this.labelStatus.TabIndex = 35;
            this.labelStatus.Text = "Status: ";
            // 
            // grpProduct
            // 
            this.grpProduct.Controls.Add(this.cboStatus);
            this.grpProduct.Controls.Add(this.labelStatus);
            this.grpProduct.Controls.Add(this.buttonUpdateProduct);
            this.grpProduct.Controls.Add(this.textPrice);
            this.grpProduct.Controls.Add(this.labelQuantity);
            this.grpProduct.Controls.Add(this.labelPrice);
            this.grpProduct.Controls.Add(this.textQuantity);
            this.grpProduct.Controls.Add(this.labelName);
            this.grpProduct.Controls.Add(this.textName);
            this.grpProduct.Location = new System.Drawing.Point(492, 146);
            this.grpProduct.Name = "grpProduct";
            this.grpProduct.Size = new System.Drawing.Size(280, 280);
            this.grpProduct.TabIndex = 37;
            this.grpProduct.TabStop = false;
            this.grpProduct.Text = "Update Product Details";
            this.grpProduct.Visible = false;
            // 
            // UpdateProduct
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
            this.Name = "UpdateProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateProduct";
            ((System.ComponentModel.ISupportInitialize)(this.grdProducts)).EndInit();
            this.grpProduct.ResumeLayout(false);
            this.grpProduct.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCloseForm;
        private System.Windows.Forms.Button buttonUpdateProduct;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textQuantity;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Button buttonSearchProduct;
        private System.Windows.Forms.Label labelSearchProduct;
        private System.Windows.Forms.TextBox textSearchProduct;
        private System.Windows.Forms.DataGridView grdProducts;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.GroupBox grpProduct;
    }
}