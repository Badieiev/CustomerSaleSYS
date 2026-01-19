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
            this.SuspendLayout();
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(164, 98);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(191, 20);
            this.textName.TabIndex = 0;
            this.textName.TextChanged += new System.EventHandler(this.textName_TextChanged);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(105, 98);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(55, 16);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name: ";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSurname.Location = new System.Drawing.Point(87, 152);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(71, 16);
            this.labelSurname.TabIndex = 2;
            this.labelSurname.Text = "Surname:";
            // 
            // textSurname
            // 
            this.textSurname.Location = new System.Drawing.Point(164, 152);
            this.textSurname.Name = "textSurname";
            this.textSurname.Size = new System.Drawing.Size(191, 20);
            this.textSurname.TabIndex = 3;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPhone.Location = new System.Drawing.Point(103, 210);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(55, 16);
            this.labelPhone.TabIndex = 4;
            this.labelPhone.Text = "Phone:";
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(164, 208);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(191, 20);
            this.textPhone.TabIndex = 5;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEmail.Location = new System.Drawing.Point(103, 266);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(55, 16);
            this.labelEmail.TabIndex = 6;
            this.labelEmail.Text = "Email:";
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(164, 262);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(191, 20);
            this.textEmail.TabIndex = 7;
            // 
            // buttonAddCustomer
            // 
            this.buttonAddCustomer.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddCustomer.Location = new System.Drawing.Point(199, 327);
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
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.buttonCloseForm);
            this.Controls.Add(this.buttonAddCustomer);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.textSurname);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textName);
            this.Name = "AddCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}