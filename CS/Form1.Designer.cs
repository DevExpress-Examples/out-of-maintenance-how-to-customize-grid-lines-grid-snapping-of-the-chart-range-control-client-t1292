namespace DateTimeChartRangeControlClient {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.rangeControl1 = new DevExpress.XtraEditors.RangeControl();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rangeControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.chartControl1.Location = new System.Drawing.Point(0, -1);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl1.Size = new System.Drawing.Size(592, 164);
            this.chartControl1.TabIndex = 0;
            // 
            // rangeControl1
            // 
            this.rangeControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));           
            this.rangeControl1.Location = new System.Drawing.Point(0, 169);
            this.rangeControl1.Name = "rangeControl1";
            this.rangeControl1.Size = new System.Drawing.Size(592, 119);
            this.rangeControl1.TabIndex = 1;
            this.rangeControl1.Text = "rangeControl1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 290);
            this.Controls.Add(this.rangeControl1);
            this.Controls.Add(this.chartControl1);
            this.Name = "Form1";           
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rangeControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.XtraEditors.RangeControl rangeControl1;
    }
}

