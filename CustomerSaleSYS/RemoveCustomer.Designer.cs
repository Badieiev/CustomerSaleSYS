namespace CustomerSaleSYS
{
    partial class RemoveCustomer
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
            this.labelCustomerId = new System.Windows.Forms.Label();
            this.textCustomerId = new System.Windows.Forms.TextBox();
            this.buttonCloseForm = new System.Windows.Forms.Button();
            this.buttonDeleteCustomer = new System.Windows.Forms.Button();
            this.grpCustomer = new System.Windows.Forms.GroupBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textSurname = new System.Windows.Forms.TextBox();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.grdCustomers = new System.Windows.Forms.DataGridView();
            this.buttonSearchCustomer = new System.Windows.Forms.Button();
            this.labelSearchCustomer = new System.Windows.Forms.Label();
            this.textSearchCustomer = new System.Windows.Forms.TextBox();
            this.grpCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCustomerId
            // 
            this.labelCustomerId.AutoSize = true;
            this.labelCustomerId.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCustomerId.Location = new System.Drawing.Point(46, 31);
            this.labelCustomerId.Name = "labelCustomerId";
            this.labelCustomerId.Size = new System.Drawing.Size(39, 16);
            this.labelCustomerId.TabIndex = 37;
            this.labelCustomerId.Text = "ID: ";
            // 
            // textCustomerId
            // 
            this.textCustomerId.Location = new System.Drawing.Point(91, 31);
            this.textCustomerId.Name = "textCustomerId";
            this.textCustomerId.ReadOnly = true;
            this.textCustomerId.Size = new System.Drawing.Size(190, 20);
            this.textCustomerId.TabIndex = 36;
            // 
            // buttonCloseForm
            // 
            this.buttonCloseForm.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCloseForm.Location = new System.Drawing.Point(654, 12);
            this.buttonCloseForm.Name = "buttonCloseForm";
            this.buttonCloseForm.Size = new System.Drawing.Size(117, 23);
            this.buttonCloseForm.TabIndex = 35;
            this.buttonCloseForm.Text = "Close Form";
            this.buttonCloseForm.UseVisualStyleBackColor = true;
            this.buttonCloseForm.Click += new System.EventHandler(this.ButtonCloseForm_Click);
            // 
            // buttonDeleteCustomer
            // 
            this.buttonDeleteCustomer.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteCustomer.Location = new System.Drawing.Point(165, 249);
            this.buttonDeleteCustomer.Name = "buttonDeleteCustomer";
            this.buttonDeleteCustomer.Size = new System.Drawing.Size(117, 23);
            this.buttonDeleteCustomer.TabIndex = 34;
            this.buttonDeleteCustomer.Text = "Delete Customer";
            this.buttonDeleteCustomer.UseVisualStyleBackColor = true;
            this.buttonDeleteCustomer.Click += new System.EventHandler(this.ButtonDeleteCustomer_Click);
            // 
            // grpCustomer
            // 
            this.grpCustomer.Controls.Add(this.textEmail);
            this.grpCustomer.Controls.Add(this.labelEmail);
            this.grpCustomer.Controls.Add(this.textPhone);
            this.grpCustomer.Controls.Add(this.labelPhone);
            this.grpCustomer.Controls.Add(this.textSurname);
            this.grpCustomer.Controls.Add(this.labelCustomerId);
            this.grpCustomer.Controls.Add(this.labelSurname);
            this.grpCustomer.Controls.Add(this.textCustomerId);
            this.grpCustomer.Controls.Add(this.labelName);
            this.grpCustomer.Controls.Add(this.textName);
            this.grpCustomer.Controls.Add(this.buttonDeleteCustomer);
            this.grpCustomer.Location = new System.Drawing.Point(484, 150);
            this.grpCustomer.Name = "grpCustomer";
            this.grpCustomer.Size = new System.Drawing.Size(287, 280);
            this.grpCustomer.TabIndex = 42;
            this.grpCustomer.TabStop = false;
            this.grpCustomer.Text = "Delete Customer Details";
            this.grpCustomer.Visible = false;
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(91, 203);
            this.textEmail.Name = "textEmail";
            this.textEmail.ReadOnly = true;
            this.textEmail.Size = new System.Drawing.Size(190, 20);
            this.textEmail.TabIndex = 17;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEmail.Location = new System.Drawing.Point(30, 207);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(55, 16);
            this.labelEmail.TabIndex = 16;
            this.labelEmail.Text = "Email:";
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(91, 159);
            this.textPhone.Name = "textPhone";
            this.textPhone.ReadOnly = true;
            this.textPhone.Size = new System.Drawing.Size(190, 20);
            this.textPhone.TabIndex = 15;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPhone.Location = new System.Drawing.Point(30, 161);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(55, 16);
            this.labelPhone.TabIndex = 14;
            this.labelPhone.Text = "Phone:";
            // 
            // textSurname
            // 
            this.textSurname.Location = new System.Drawing.Point(91, 116);
            this.textSurname.Name = "textSurname";
            this.textSurname.ReadOnly = true;
            this.textSurname.Size = new System.Drawing.Size(190, 20);
            this.textSurname.TabIndex = 13;
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSurname.Location = new System.Drawing.Point(14, 116);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(71, 16);
            this.labelSurname.TabIndex = 12;
            this.labelSurname.Text = "Surname:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(32, 75);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(55, 16);
            this.labelName.TabIndex = 11;
            this.labelName.Text = "Name: ";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(91, 75);
            this.textName.Name = "textName";
            this.textName.ReadOnly = true;
            this.textName.Size = new System.Drawing.Size(190, 20);
            this.textName.TabIndex = 10;
            // 
            // grdCustomers
            // 
            this.grdCustomers.AllowUserToAddRows = false;
            this.grdCustomers.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.grdCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCustomers.Location = new System.Drawing.Point(24, 150);
            this.grdCustomers.Name = "grdCustomers";
            this.grdCustomers.Size = new System.Drawing.Size(450, 280);
            this.grdCustomers.TabIndex = 41;
            this.grdCustomers.Visible = false;
            this.grdCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdCustomersCellClick);
            // 
            // buttonSearchCustomer
            // 
            this.buttonSearchCustomer.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearchCustomer.Location = new System.Drawing.Point(484, 48);
            this.buttonSearchCustomer.Name = "buttonSearchCustomer";
            this.buttonSearchCustomer.Size = new System.Drawing.Size(117, 23);
            this.buttonSearchCustomer.TabIndex = 40;
            this.buttonSearchCustomer.Text = "Search";
            this.buttonSearchCustomer.UseVisualStyleBackColor = true;
            this.buttonSearchCustomer.Click += new System.EventHandler(this.ButtonSearchCustomer_Click);
            // 
            // labelSearchCustomer
            // 
            this.labelSearchCustomer.AutoSize = true;
            this.labelSearchCustomer.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSearchCustomer.Location = new System.Drawing.Point(21, 52);
            this.labelSearchCustomer.Name = "labelSearchCustomer";
            this.labelSearchCustomer.Size = new System.Drawing.Size(255, 32);
            this.labelSearchCustomer.TabIndex = 39;
            this.labelSearchCustomer.Text = "Enter customer name or surname,\r\n initials or part of data";
            // 
            // textSearchCustomer
            // 
            this.textSearchCustomer.Location = new System.Drawing.Point(287, 50);
            this.textSearchCustomer.Name = "textSearchCustomer";
            this.textSearchCustomer.Size = new System.Drawing.Size(190, 20);
            this.textSearchCustomer.TabIndex = 38;
            // 
            // RemoveCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.grpCustomer);
            this.Controls.Add(this.grdCustomers);
            this.Controls.Add(this.buttonSearchCustomer);
            this.Controls.Add(this.labelSearchCustomer);
            this.Controls.Add(this.textSearchCustomer);
            this.Controls.Add(this.buttonCloseForm);
            this.Name = "RemoveCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RemoveCustomer";
            this.grpCustomer.ResumeLayout(false);
            this.grpCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelCustomerId;
        private System.Windows.Forms.TextBox textCustomerId;
        private System.Windows.Forms.Button buttonCloseForm;
        private System.Windows.Forms.Button buttonDeleteCustomer;
        private System.Windows.Forms.GroupBox grpCustomer;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textSurname;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.DataGridView grdCustomers;
        private System.Windows.Forms.Button buttonSearchCustomer;
        private System.Windows.Forms.Label labelSearchCustomer;
        private System.Windows.Forms.TextBox textSearchCustomer;
    }
}