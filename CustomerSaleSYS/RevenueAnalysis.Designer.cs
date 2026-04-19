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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.buttonCloseForm = new System.Windows.Forms.Button();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.labelYear = new System.Windows.Forms.Label();
            this.buttonShowGraph = new System.Windows.Forms.Button();
            this.chtData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chtData)).BeginInit();
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
            this.buttonCloseForm.Click += new System.EventHandler(this.ButtonCloseForm_Click);
            // 
            // cboYear
            // 
            this.cboYear.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Items.AddRange(new object[] {
            "2024",
            "2025"});
            this.cboYear.Location = new System.Drawing.Point(159, 13);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(191, 24);
            this.cboYear.TabIndex = 56;
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelYear.Location = new System.Drawing.Point(106, 16);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(47, 16);
            this.labelYear.TabIndex = 55;
            this.labelYear.Text = "Year:";
            // 
            // buttonShowGraph
            // 
            this.buttonShowGraph.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowGraph.Location = new System.Drawing.Point(366, 12);
            this.buttonShowGraph.Name = "buttonShowGraph";
            this.buttonShowGraph.Size = new System.Drawing.Size(117, 23);
            this.buttonShowGraph.TabIndex = 54;
            this.buttonShowGraph.Text = "Show Graph";
            this.buttonShowGraph.UseVisualStyleBackColor = true;
            this.buttonShowGraph.Click += new System.EventHandler(this.ButtonShowGraph_Click);
            // 
            // chtData
            // 
            chartArea2.Name = "ChartArea1";
            this.chtData.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chtData.Legends.Add(legend2);
            this.chtData.Location = new System.Drawing.Point(111, 107);
            this.chtData.Name = "chtData";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chtData.Series.Add(series2);
            this.chtData.Size = new System.Drawing.Size(571, 300);
            this.chtData.TabIndex = 58;
            this.chtData.Text = "chart1";
            // 
            // RevenueAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.chtData);
            this.Controls.Add(this.cboYear);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.buttonShowGraph);
            this.Controls.Add(this.buttonCloseForm);
            this.Name = "RevenueAnalysis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RevenueAnalysis";
            this.Load += new System.EventHandler(this.FormRevenueAnalysisLoad);
            ((System.ComponentModel.ISupportInitialize)(this.chtData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCloseForm;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Button buttonShowGraph;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtData;
    }
}