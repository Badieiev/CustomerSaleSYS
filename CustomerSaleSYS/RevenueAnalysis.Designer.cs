namespace CustomerSaleSYS
{
    partial class RevenueAnalysis
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
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.labelYear = new System.Windows.Forms.Label();
            this.buttonShowGraph = new System.Windows.Forms.Button();
            this.pictureBoxRevenue = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRevenue)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCloseForm
            // 
            this.buttonCloseForm.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCloseForm.Location = new System.Drawing.Point(655, 12);
            this.buttonCloseForm.Name = "buttonCloseForm";
            this.buttonCloseForm.Size = new System.Drawing.Size(117, 23);
            this.buttonCloseForm.TabIndex = 36;
            this.buttonCloseForm.Text = "Close Form";
            this.buttonCloseForm.UseVisualStyleBackColor = true;
            this.buttonCloseForm.Click += new System.EventHandler(this.buttonCloseForm_Click);
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxYear.FormattingEnabled = true;
            this.comboBoxYear.Items.AddRange(new object[] {
            "2024",
            "2025"});
            this.comboBoxYear.Location = new System.Drawing.Point(86, 13);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(191, 24);
            this.comboBoxYear.TabIndex = 56;
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelYear.Location = new System.Drawing.Point(33, 16);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(47, 16);
            this.labelYear.TabIndex = 55;
            this.labelYear.Text = "Year:";
            // 
            // buttonShowGraph
            // 
            this.buttonShowGraph.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowGraph.Location = new System.Drawing.Point(293, 12);
            this.buttonShowGraph.Name = "buttonShowGraph";
            this.buttonShowGraph.Size = new System.Drawing.Size(117, 23);
            this.buttonShowGraph.TabIndex = 54;
            this.buttonShowGraph.Text = "Show Graph";
            this.buttonShowGraph.UseVisualStyleBackColor = true;
            this.buttonShowGraph.Click += new System.EventHandler(this.buttonShowGraph_Click);
            // 
            // pictureBoxRevenue
            // 
            this.pictureBoxRevenue.Location = new System.Drawing.Point(86, 78);
            this.pictureBoxRevenue.Name = "pictureBoxRevenue";
            this.pictureBoxRevenue.Size = new System.Drawing.Size(600, 371);
            this.pictureBoxRevenue.TabIndex = 57;
            this.pictureBoxRevenue.TabStop = false;
            this.pictureBoxRevenue.Visible = false;
            // 
            // RevenueAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.pictureBoxRevenue);
            this.Controls.Add(this.comboBoxYear);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.buttonShowGraph);
            this.Controls.Add(this.buttonCloseForm);
            this.Name = "RevenueAnalysis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RevenueAnalysis";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRevenue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCloseForm;
        private System.Windows.Forms.ComboBox comboBoxYear;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Button buttonShowGraph;
        private System.Windows.Forms.PictureBox pictureBoxRevenue;
    }
}