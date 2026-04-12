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
            this.cboCustomer = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.buttonCloseForm = new System.Windows.Forms.Button();
            this.btnUpdateOrder_item = new System.Windows.Forms.Button();
            this.labelDate = new System.Windows.Forms.Label();
            this.textQuantity = new System.Windows.Forms.TextBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.buttonSearchOrder = new System.Windows.Forms.Button();
            this.labelSearchCustomer = new System.Windows.Forms.Label();
            this.textSearchOrder = new System.Windows.Forms.TextBox();
            this.labelProductId = new System.Windows.Forms.Label();
            this.textOrderId = new System.Windows.Forms.TextBox();
            this.grdOrders = new System.Windows.Forms.DataGridView();
            this.grdOrder_items = new System.Windows.Forms.DataGridView();
            this.grpOrder = new System.Windows.Forms.GroupBox();
            this.btnUpdateOrder = new System.Windows.Forms.Button();
            this.grpProduct = new System.Windows.Forms.GroupBox();
            this.btnDeleteOrder_item = new System.Windows.Forms.Button();
            this.btnAddOrder_item = new System.Windows.Forms.Button();
            this.cboProduct = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrder_items)).BeginInit();
            this.grpOrder.SuspendLayout();
            this.grpProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelProduct
            // 
            this.labelProduct.AutoSize = true;
            this.labelProduct.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProduct.Location = new System.Drawing.Point(508, 28);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(71, 16);
            this.labelProduct.TabIndex = 43;
            this.labelProduct.Text = "Product:";
            // 
            // labelCustomer
            // 
            this.labelCustomer.AutoSize = true;
            this.labelCustomer.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCustomer.Location = new System.Drawing.Point(502, 65);
            this.labelCustomer.Name = "labelCustomer";
            this.labelCustomer.Size = new System.Drawing.Size(79, 16);
            this.labelCustomer.TabIndex = 42;
            this.labelCustomer.Text = "Customer:";
            // 
            // cboCustomer
            // 
            this.cboCustomer.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboCustomer.FormattingEnabled = true;
            this.cboCustomer.Location = new System.Drawing.Point(587, 62);
            this.cboCustomer.Name = "cboCustomer";
            this.cboCustomer.Size = new System.Drawing.Size(191, 24);
            this.cboCustomer.TabIndex = 41;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(587, 106);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(191, 20);
            this.dateTimePicker.TabIndex = 39;
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
            this.buttonCloseForm.Click += new System.EventHandler(this.ButtonCloseForm_Click);
            // 
            // btnUpdateOrder_item
            // 
            this.btnUpdateOrder_item.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdateOrder_item.Location = new System.Drawing.Point(659, 168);
            this.btnUpdateOrder_item.Name = "btnUpdateOrder_item";
            this.btnUpdateOrder_item.Size = new System.Drawing.Size(117, 23);
            this.btnUpdateOrder_item.TabIndex = 37;
            this.btnUpdateOrder_item.Text = "Update";
            this.btnUpdateOrder_item.UseVisualStyleBackColor = true;
            this.btnUpdateOrder_item.Click += new System.EventHandler(this.BtnUpdateOrder_item_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDate.Location = new System.Drawing.Point(534, 110);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(47, 16);
            this.labelDate.TabIndex = 36;
            this.labelDate.Text = "Date:";
            // 
            // textQuantity
            // 
            this.textQuantity.Location = new System.Drawing.Point(585, 72);
            this.textQuantity.Name = "textQuantity";
            this.textQuantity.Size = new System.Drawing.Size(191, 20);
            this.textQuantity.TabIndex = 35;
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQuantity.Location = new System.Drawing.Point(500, 72);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(79, 16);
            this.labelQuantity.TabIndex = 34;
            this.labelQuantity.Text = "Quantity:";
            // 
            // buttonSearchOrder
            // 
            this.buttonSearchOrder.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearchOrder.Location = new System.Drawing.Point(349, 12);
            this.buttonSearchOrder.Name = "buttonSearchOrder";
            this.buttonSearchOrder.Size = new System.Drawing.Size(117, 23);
            this.buttonSearchOrder.TabIndex = 46;
            this.buttonSearchOrder.Text = "Search";
            this.buttonSearchOrder.UseVisualStyleBackColor = true;
            this.buttonSearchOrder.Click += new System.EventHandler(this.ButtonSearchOrder_Click);
            // 
            // labelSearchCustomer
            // 
            this.labelSearchCustomer.AutoSize = true;
            this.labelSearchCustomer.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSearchCustomer.Location = new System.Drawing.Point(11, 16);
            this.labelSearchCustomer.Name = "labelSearchCustomer";
            this.labelSearchCustomer.Size = new System.Drawing.Size(135, 16);
            this.labelSearchCustomer.TabIndex = 45;
            this.labelSearchCustomer.Text = "Enter Order ID: ";
            // 
            // textSearchOrder
            // 
            this.textSearchOrder.Location = new System.Drawing.Point(152, 14);
            this.textSearchOrder.Name = "textSearchOrder";
            this.textSearchOrder.Size = new System.Drawing.Size(191, 20);
            this.textSearchOrder.TabIndex = 44;
            // 
            // labelProductId
            // 
            this.labelProductId.AutoSize = true;
            this.labelProductId.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProductId.Location = new System.Drawing.Point(542, 25);
            this.labelProductId.Name = "labelProductId";
            this.labelProductId.Size = new System.Drawing.Size(39, 16);
            this.labelProductId.TabIndex = 49;
            this.labelProductId.Text = "ID: ";
            // 
            // textOrderId
            // 
            this.textOrderId.Location = new System.Drawing.Point(587, 25);
            this.textOrderId.Name = "textOrderId";
            this.textOrderId.ReadOnly = true;
            this.textOrderId.Size = new System.Drawing.Size(191, 20);
            this.textOrderId.TabIndex = 48;
            // 
            // grdOrders
            // 
            this.grdOrders.AllowUserToAddRows = false;
            this.grdOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOrders.Location = new System.Drawing.Point(2, 17);
            this.grdOrders.Name = "grdOrders";
            this.grdOrders.Size = new System.Drawing.Size(440, 180);
            this.grdOrders.TabIndex = 54;
            this.grdOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdOrdersCellClick);
            // 
            // grdOrder_items
            // 
            this.grdOrder_items.AllowUserToAddRows = false;
            this.grdOrder_items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOrder_items.Location = new System.Drawing.Point(2, 17);
            this.grdOrder_items.Name = "grdOrder_items";
            this.grdOrder_items.Size = new System.Drawing.Size(440, 180);
            this.grdOrder_items.TabIndex = 55;
            this.grdOrder_items.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdOrder_itemsCellClick);
            // 
            // grpOrder
            // 
            this.grpOrder.Controls.Add(this.btnUpdateOrder);
            this.grpOrder.Controls.Add(this.grdOrders);
            this.grpOrder.Controls.Add(this.labelProductId);
            this.grpOrder.Controls.Add(this.textOrderId);
            this.grpOrder.Controls.Add(this.labelCustomer);
            this.grpOrder.Controls.Add(this.cboCustomer);
            this.grpOrder.Controls.Add(this.dateTimePicker);
            this.grpOrder.Controls.Add(this.labelDate);
            this.grpOrder.Location = new System.Drawing.Point(12, 40);
            this.grpOrder.Name = "grpOrder";
            this.grpOrder.Size = new System.Drawing.Size(785, 200);
            this.grpOrder.TabIndex = 56;
            this.grpOrder.TabStop = false;
            this.grpOrder.Text = "Order Details: Update Customer or Date";
            // 
            // btnUpdateOrder
            // 
            this.btnUpdateOrder.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdateOrder.Location = new System.Drawing.Point(623, 161);
            this.btnUpdateOrder.Name = "btnUpdateOrder";
            this.btnUpdateOrder.Size = new System.Drawing.Size(117, 23);
            this.btnUpdateOrder.TabIndex = 58;
            this.btnUpdateOrder.Text = "Update";
            this.btnUpdateOrder.UseVisualStyleBackColor = true;
            this.btnUpdateOrder.Click += new System.EventHandler(this.BtnUpdateOrder_Click);
            // 
            // grpProduct
            // 
            this.grpProduct.Controls.Add(this.cboProduct);
            this.grpProduct.Controls.Add(this.btnAddOrder_item);
            this.grpProduct.Controls.Add(this.btnDeleteOrder_item);
            this.grpProduct.Controls.Add(this.grdOrder_items);
            this.grpProduct.Controls.Add(this.labelProduct);
            this.grpProduct.Controls.Add(this.btnUpdateOrder_item);
            this.grpProduct.Controls.Add(this.textQuantity);
            this.grpProduct.Controls.Add(this.labelQuantity);
            this.grpProduct.Location = new System.Drawing.Point(12, 247);
            this.grpProduct.Name = "grpProduct";
            this.grpProduct.Size = new System.Drawing.Size(785, 200);
            this.grpProduct.TabIndex = 57;
            this.grpProduct.TabStop = false;
            this.grpProduct.Text = "Order_items Details: Update Product or Quantity";
            // 
            // btnDeleteOrder_item
            // 
            this.btnDeleteOrder_item.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteOrder_item.Location = new System.Drawing.Point(511, 168);
            this.btnDeleteOrder_item.Name = "btnDeleteOrder_item";
            this.btnDeleteOrder_item.Size = new System.Drawing.Size(117, 23);
            this.btnDeleteOrder_item.TabIndex = 58;
            this.btnDeleteOrder_item.Text = "Delete";
            this.btnDeleteOrder_item.UseVisualStyleBackColor = true;
            // 
            // btnAddOrder_item
            // 
            this.btnAddOrder_item.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddOrder_item.Location = new System.Drawing.Point(659, 124);
            this.btnAddOrder_item.Name = "btnAddOrder_item";
            this.btnAddOrder_item.Size = new System.Drawing.Size(117, 23);
            this.btnAddOrder_item.TabIndex = 59;
            this.btnAddOrder_item.Text = "Add";
            this.btnAddOrder_item.UseVisualStyleBackColor = true;
            // 
            // cboProduct
            // 
            this.cboProduct.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboProduct.FormattingEnabled = true;
            this.cboProduct.Location = new System.Drawing.Point(585, 25);
            this.cboProduct.Name = "cboProduct";
            this.cboProduct.Size = new System.Drawing.Size(191, 24);
            this.cboProduct.TabIndex = 58;
            // 
            // UpdateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpProduct);
            this.Controls.Add(this.grpOrder);
            this.Controls.Add(this.buttonCloseForm);
            this.Controls.Add(this.buttonSearchOrder);
            this.Controls.Add(this.textSearchOrder);
            this.Controls.Add(this.labelSearchCustomer);
            this.Name = "UpdateOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateOrder";
            this.Load += new System.EventHandler(this.FormUpdateOrderLoad);
            ((System.ComponentModel.ISupportInitialize)(this.grdOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrder_items)).EndInit();
            this.grpOrder.ResumeLayout(false);
            this.grpOrder.PerformLayout();
            this.grpProduct.ResumeLayout(false);
            this.grpProduct.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.Label labelCustomer;
        private System.Windows.Forms.ComboBox cboCustomer;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button buttonCloseForm;
        private System.Windows.Forms.Button btnUpdateOrder_item;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.TextBox textQuantity;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Button buttonSearchOrder;
        private System.Windows.Forms.Label labelSearchCustomer;
        private System.Windows.Forms.TextBox textSearchOrder;
        private System.Windows.Forms.Label labelProductId;
        private System.Windows.Forms.TextBox textOrderId;
        private System.Windows.Forms.DataGridView grdOrders;
        private System.Windows.Forms.DataGridView grdOrder_items;
        private System.Windows.Forms.GroupBox grpOrder;
        private System.Windows.Forms.GroupBox grpProduct;
        private System.Windows.Forms.Button btnUpdateOrder;
        private System.Windows.Forms.Button btnDeleteOrder_item;
        private System.Windows.Forms.Button btnAddOrder_item;
        private System.Windows.Forms.ComboBox cboProduct;
    }
}