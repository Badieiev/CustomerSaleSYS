namespace CustomerSaleSYS
{
    partial class AddCustomer
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
            this.textName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.textSurname = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.buttonAddCustomer = new System.Windows.Forms.Button();
            this.buttonCloseForm = new System.Windows.Forms.Button();
            this.labelID = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.grpCustomer = new System.Windows.Forms.GroupBox();
            this.grpCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(94, 86);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(191, 20);
            this.textName.TabIndex = 0;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(35, 86);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(55, 16);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name: ";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSurname.Location = new System.Drawing.Point(17, 140);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(71, 16);
            this.labelSurname.TabIndex = 2;
            this.labelSurname.Text = "Surname:";
            // 
            // textSurname
            // 
            this.textSurname.Location = new System.Drawing.Point(94, 140);
            this.textSurname.Name = "textSurname";
            this.textSurname.Size = new System.Drawing.Size(191, 20);
            this.textSurname.TabIndex = 3;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPhone.Location = new System.Drawing.Point(33, 198);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(55, 16);
            this.labelPhone.TabIndex = 4;
            this.labelPhone.Text = "Phone:";
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(94, 196);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(191, 20);
            this.textPhone.TabIndex = 5;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEmail.Location = new System.Drawing.Point(33, 254);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(55, 16);
            this.labelEmail.TabIndex = 6;
            this.labelEmail.Text = "Email:";
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(94, 250);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(191, 20);
            this.textEmail.TabIndex = 7;
            // 
            // buttonAddCustomer
            // 
            this.buttonAddCustomer.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddCustomer.Location = new System.Drawing.Point(129, 315);
            this.buttonAddCustomer.Name = "buttonAddCustomer";
            this.buttonAddCustomer.Size = new System.Drawing.Size(117, 23);
            this.buttonAddCustomer.TabIndex = 8;
            this.buttonAddCustomer.Text = "Add Customer";
            this.buttonAddCustomer.UseVisualStyleBackColor = true;
            this.buttonAddCustomer.Click += new System.EventHandler(this.buttonAddCustomer_Click);
            // 
            // buttonCloseForm
            // 
            this.buttonCloseForm.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCloseForm.Location = new System.Drawing.Point(355, 12);
            this.buttonCloseForm.Name = "buttonCloseForm";
            this.buttonCloseForm.Size = new System.Drawing.Size(117, 23);
            this.buttonCloseForm.TabIndex = 9;
            this.buttonCloseForm.Text = "Close Form";
            this.buttonCloseForm.UseVisualStyleBackColor = true;
            this.buttonCloseForm.Click += new System.EventHandler(this.buttonCloseForm_Click);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelID.Location = new System.Drawing.Point(49, 36);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(39, 16);
            this.labelID.TabIndex = 10;
            this.labelID.Text = "ID: ";
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(94, 36);
            this.textID.Name = "textID";
            this.textID.ReadOnly = true;
            this.textID.Size = new System.Drawing.Size(191, 20);
            this.textID.TabIndex = 11;
            // 
            // grpCustomer
            // 
            this.grpCustomer.Controls.Add(this.textID);
            this.grpCustomer.Controls.Add(this.labelID);
            this.grpCustomer.Controls.Add(this.buttonAddCustomer);
            this.grpCustomer.Controls.Add(this.textEmail);
            this.grpCustomer.Controls.Add(this.labelEmail);
            this.grpCustomer.Controls.Add(this.textPhone);
            this.grpCustomer.Controls.Add(this.labelPhone);
            this.grpCustomer.Controls.Add(this.textSurname);
            this.grpCustomer.Controls.Add(this.labelSurname);
            this.grpCustomer.Controls.Add(this.labelName);
            this.grpCustomer.Controls.Add(this.textName);
            this.grpCustomer.Location = new System.Drawing.Point(70, 65);
            this.grpCustomer.Name = "grpCustomer";
            this.grpCustomer.Size = new System.Drawing.Size(350, 350);
            this.grpCustomer.TabIndex = 12;
            this.grpCustomer.TabStop = false;
            this.grpCustomer.Text = "Enter Customer details";
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.grpCustomer);
            this.Controls.Add(this.buttonCloseForm);
            this.Name = "AddCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCustomer";
            this.Load += new System.EventHandler(this.FormAddCustomerLoad);
            this.grpCustomer.ResumeLayout(false);
            this.grpCustomer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.TextBox textSurname;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Button buttonAddCustomer;
        private System.Windows.Forms.Button buttonCloseForm;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.GroupBox grpCustomer;
    }
}