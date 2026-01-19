namespace CustomerSaleSYS
{
    partial class UpdateCustomer
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
            this.buttonUpdateCustomer = new System.Windows.Forms.Button();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textSurname = new System.Windows.Forms.TextBox();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.labelCustomerId = new System.Windows.Forms.Label();
            this.textCustomerId = new System.Windows.Forms.TextBox();
            this.labelSearchCustomer = new System.Windows.Forms.Label();
            this.textSearchCustomer = new System.Windows.Forms.TextBox();
            this.buttonSearchCustomer = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonCloseForm
            // 
            this.buttonCloseForm.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCloseForm.Location = new System.Drawing.Point(655, 12);
            this.buttonCloseForm.Name = "buttonCloseForm";
            this.buttonCloseForm.Size = new System.Drawing.Size(117, 23);
            this.buttonCloseForm.TabIndex = 19;
            this.buttonCloseForm.Text = "Close Form";
            this.buttonCloseForm.UseVisualStyleBackColor = true;
            this.buttonCloseForm.Click += new System.EventHandler(this.buttonCloseForm_Click);
            // 
            // buttonUpdateCustomer
            // 
            this.buttonUpdateCustomer.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpdateCustomer.Location = new System.Drawing.Point(625, 415);
            this.buttonUpdateCustomer.Name = "buttonUpdateCustomer";
            this.buttonUpdateCustomer.Size = new System.Drawing.Size(117, 23);
            this.buttonUpdateCustomer.TabIndex = 18;
            this.buttonUpdateCustomer.Text = "Update Customer";
            this.buttonUpdateCustomer.UseVisualStyleBackColor = true;
            this.buttonUpdateCustomer.Visible = false;
            this.buttonUpdateCustomer.Click += new System.EventHandler(this.buttonUpdateCustomer_Click);
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(583, 358);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(191, 20);
            this.textEmail.TabIndex = 17;
            this.textEmail.Text = "email@doman.ie";
            this.textEmail.Visible = false;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEmail.Location = new System.Drawing.Point(522, 362);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(55, 16);
            this.labelEmail.TabIndex = 16;
            this.labelEmail.Text = "Email:";
            this.labelEmail.Visible = false;
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(583, 304);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(191, 20);
            this.textPhone.TabIndex = 15;
            this.textPhone.Text = "0851234567";
            this.textPhone.Visible = false;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPhone.Location = new System.Drawing.Point(522, 306);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(55, 16);
            this.labelPhone.TabIndex = 14;
            this.labelPhone.Text = "Phone:";
            this.labelPhone.Visible = false;
            // 
            // textSurname
            // 
            this.textSurname.Location = new System.Drawing.Point(583, 248);
            this.textSurname.Name = "textSurname";
            this.textSurname.Size = new System.Drawing.Size(191, 20);
            this.textSurname.TabIndex = 13;
            this.textSurname.Text = "Murphy";
            this.textSurname.Visible = false;
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSurname.Location = new System.Drawing.Point(506, 248);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(71, 16);
            this.labelSurname.TabIndex = 12;
            this.labelSurname.Text = "Surname:";
            this.labelSurname.Visible = false;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(524, 194);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(55, 16);
            this.labelName.TabIndex = 11;
            this.labelName.Text = "Name: ";
            this.labelName.Visible = false;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(583, 194);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(191, 20);
            this.textName.TabIndex = 10;
            this.textName.Text = "Roisin";
            this.textName.Visible = false;
            // 
            // labelCustomerId
            // 
            this.labelCustomerId.AutoSize = true;
            this.labelCustomerId.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCustomerId.Location = new System.Drawing.Point(536, 145);
            this.labelCustomerId.Name = "labelCustomerId";
            this.labelCustomerId.Size = new System.Drawing.Size(39, 16);
            this.labelCustomerId.TabIndex = 21;
            this.labelCustomerId.Text = "ID: ";
            this.labelCustomerId.Visible = false;
            // 
            // textCustomerId
            // 
            this.textCustomerId.Location = new System.Drawing.Point(581, 145);
            this.textCustomerId.Name = "textCustomerId";
            this.textCustomerId.ReadOnly = true;
            this.textCustomerId.Size = new System.Drawing.Size(191, 20);
            this.textCustomerId.TabIndex = 20;
            this.textCustomerId.Text = "5";
            this.textCustomerId.Visible = false;
            // 
            // labelSearchCustomer
            // 
            this.labelSearchCustomer.AutoSize = true;
            this.labelSearchCustomer.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSearchCustomer.Location = new System.Drawing.Point(29, 64);
            this.labelSearchCustomer.Name = "labelSearchCustomer";
            this.labelSearchCustomer.Size = new System.Drawing.Size(71, 16);
            this.labelSearchCustomer.TabIndex = 23;
            this.labelSearchCustomer.Text = "Search: ";
            // 
            // textSearchCustomer
            // 
            this.textSearchCustomer.Location = new System.Drawing.Point(106, 64);
            this.textSearchCustomer.Name = "textSearchCustomer";
            this.textSearchCustomer.Size = new System.Drawing.Size(191, 20);
            this.textSearchCustomer.TabIndex = 22;
            // 
            // buttonSearchCustomer
            // 
            this.buttonSearchCustomer.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearchCustomer.Location = new System.Drawing.Point(331, 61);
            this.buttonSearchCustomer.Name = "buttonSearchCustomer";
            this.buttonSearchCustomer.Size = new System.Drawing.Size(117, 23);
            this.buttonSearchCustomer.TabIndex = 24;
            this.buttonSearchCustomer.Text = "Search";
            this.buttonSearchCustomer.UseVisualStyleBackColor = true;
            this.buttonSearchCustomer.Click += new System.EventHandler(this.buttonSearchCustomer_Click);
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
            this.listBox1.Location = new System.Drawing.Point(32, 145);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(416, 228);
            this.listBox1.TabIndex = 25;
            // 
            // UpdateCustomer
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
            this.Controls.Add(this.buttonUpdateCustomer);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.textSurname);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textName);
            this.Name = "UpdateCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCloseForm;
        private System.Windows.Forms.Button buttonUpdateCustomer;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textSurname;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label labelCustomerId;
        private System.Windows.Forms.TextBox textCustomerId;
        private System.Windows.Forms.Label labelSearchCustomer;
        private System.Windows.Forms.TextBox textSearchCustomer;
        private System.Windows.Forms.Button buttonSearchCustomer;
        private System.Windows.Forms.ListBox listBox1;
    }
}