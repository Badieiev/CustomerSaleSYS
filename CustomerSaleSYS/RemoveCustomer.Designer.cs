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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonSearchCustomer = new System.Windows.Forms.Button();
            this.labelSearchCustomer = new System.Windows.Forms.Label();
            this.textSearchCustomer = new System.Windows.Forms.TextBox();
            this.labelCustomerId = new System.Windows.Forms.Label();
            this.textCustomerId = new System.Windows.Forms.TextBox();
            this.buttonCloseForm = new System.Windows.Forms.Button();
            this.buttonDeleteCustomer = new System.Windows.Forms.Button();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textSurname = new System.Windows.Forms.TextBox();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "ID:1, Forename:Aisling, Surname:Sullivan, Phone:0851234576, Email:email1@domain.i" +
                "e",
            "ID:2, Forename:Ronan, Surname:Brady, Phone:0857654321, Email:example@domain.ie",
            "ID:3, Forename:Connor, Surname:Kelly, Phone:0852134567, Email:mail11@google.com",
            "ID:4, Forename:Aoife, Surname:Brennan, Phone:0853125467, Email:ema@mail.com",
            "ID:5, Forename:Roisin, Surname:Murphy, Phone:0851234567, Email:email5@domain.ie"});
            this.listBox1.Location = new System.Drawing.Point(31, 145);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(416, 228);
            this.listBox1.TabIndex = 41;
            // 
            // buttonSearchCustomer
            // 
            this.buttonSearchCustomer.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearchCustomer.Location = new System.Drawing.Point(330, 61);
            this.buttonSearchCustomer.Name = "buttonSearchCustomer";
            this.buttonSearchCustomer.Size = new System.Drawing.Size(117, 23);
            this.buttonSearchCustomer.TabIndex = 40;
            this.buttonSearchCustomer.Text = "Search";
            this.buttonSearchCustomer.UseVisualStyleBackColor = true;
            this.buttonSearchCustomer.Click += new System.EventHandler(this.buttonSearchCustomer_Click);
            // 
            // labelSearchCustomer
            // 
            this.labelSearchCustomer.AutoSize = true;
            this.labelSearchCustomer.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSearchCustomer.Location = new System.Drawing.Point(28, 64);
            this.labelSearchCustomer.Name = "labelSearchCustomer";
            this.labelSearchCustomer.Size = new System.Drawing.Size(71, 16);
            this.labelSearchCustomer.TabIndex = 39;
            this.labelSearchCustomer.Text = "Search: ";
            // 
            // textSearchCustomer
            // 
            this.textSearchCustomer.Location = new System.Drawing.Point(105, 64);
            this.textSearchCustomer.Name = "textSearchCustomer";
            this.textSearchCustomer.Size = new System.Drawing.Size(191, 20);
            this.textSearchCustomer.TabIndex = 38;
            // 
            // labelCustomerId
            // 
            this.labelCustomerId.AutoSize = true;
            this.labelCustomerId.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCustomerId.Location = new System.Drawing.Point(535, 145);
            this.labelCustomerId.Name = "labelCustomerId";
            this.labelCustomerId.Size = new System.Drawing.Size(39, 16);
            this.labelCustomerId.TabIndex = 37;
            this.labelCustomerId.Text = "ID: ";
            this.labelCustomerId.Visible = false;
            // 
            // textCustomerId
            // 
            this.textCustomerId.Location = new System.Drawing.Point(580, 145);
            this.textCustomerId.Name = "textCustomerId";
            this.textCustomerId.ReadOnly = true;
            this.textCustomerId.Size = new System.Drawing.Size(191, 20);
            this.textCustomerId.TabIndex = 36;
            this.textCustomerId.Text = "5";
            this.textCustomerId.Visible = false;
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
            this.buttonCloseForm.Click += new System.EventHandler(this.buttonCloseForm_Click);
            // 
            // buttonDeleteCustomer
            // 
            this.buttonDeleteCustomer.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteCustomer.Location = new System.Drawing.Point(624, 415);
            this.buttonDeleteCustomer.Name = "buttonDeleteCustomer";
            this.buttonDeleteCustomer.Size = new System.Drawing.Size(117, 23);
            this.buttonDeleteCustomer.TabIndex = 34;
            this.buttonDeleteCustomer.Text = "Delete Customer";
            this.buttonDeleteCustomer.UseVisualStyleBackColor = true;
            this.buttonDeleteCustomer.Visible = false;
            this.buttonDeleteCustomer.Click += new System.EventHandler(this.buttonDeleteCustomer_Click);
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(582, 358);
            this.textEmail.Name = "textEmail";
            this.textEmail.ReadOnly = true;
            this.textEmail.Size = new System.Drawing.Size(191, 20);
            this.textEmail.TabIndex = 33;
            this.textEmail.Text = "email@doman.ie";
            this.textEmail.Visible = false;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEmail.Location = new System.Drawing.Point(521, 362);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(55, 16);
            this.labelEmail.TabIndex = 32;
            this.labelEmail.Text = "Email:";
            this.labelEmail.Visible = false;
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(582, 304);
            this.textPhone.Name = "textPhone";
            this.textPhone.ReadOnly = true;
            this.textPhone.Size = new System.Drawing.Size(191, 20);
            this.textPhone.TabIndex = 31;
            this.textPhone.Text = "0851234567";
            this.textPhone.Visible = false;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPhone.Location = new System.Drawing.Point(521, 306);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(55, 16);
            this.labelPhone.TabIndex = 30;
            this.labelPhone.Text = "Phone:";
            this.labelPhone.Visible = false;
            // 
            // textSurname
            // 
            this.textSurname.Location = new System.Drawing.Point(582, 248);
            this.textSurname.Name = "textSurname";
            this.textSurname.ReadOnly = true;
            this.textSurname.Size = new System.Drawing.Size(191, 20);
            this.textSurname.TabIndex = 29;
            this.textSurname.Text = "Murphy";
            this.textSurname.Visible = false;
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSurname.Location = new System.Drawing.Point(505, 248);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(71, 16);
            this.labelSurname.TabIndex = 28;
            this.labelSurname.Text = "Surname:";
            this.labelSurname.Visible = false;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(523, 194);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(55, 16);
            this.labelName.TabIndex = 27;
            this.labelName.Text = "Name: ";
            this.labelName.Visible = false;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(582, 194);
            this.textName.Name = "textName";
            this.textName.ReadOnly = true;
            this.textName.Size = new System.Drawing.Size(191, 20);
            this.textName.TabIndex = 26;
            this.textName.Text = "Roisin";
            this.textName.Visible = false;
            // 
            // RemoveCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonSearchCustomer);
            this.Controls.Add(this.labelSearchCustomer);
            this.Controls.Add(this.textSearchCustomer);
            this.Controls.Add(this.labelCustomerId);
            this.Controls.Add(this.textCustomerId);
            this.Controls.Add(this.buttonCloseForm);
            this.Controls.Add(this.buttonDeleteCustomer);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.textSurname);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textName);
            this.Name = "RemoveCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RemoveCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonSearchCustomer;
        private System.Windows.Forms.Label labelSearchCustomer;
        private System.Windows.Forms.TextBox textSearchCustomer;
        private System.Windows.Forms.Label labelCustomerId;
        private System.Windows.Forms.TextBox textCustomerId;
        private System.Windows.Forms.Button buttonCloseForm;
        private System.Windows.Forms.Button buttonDeleteCustomer;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textSurname;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textName;
    }
}