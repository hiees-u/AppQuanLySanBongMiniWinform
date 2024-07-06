namespace DoAN.NET_.Forms
{
    partial class frmThongKeLichDS
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnLoadDuLieu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DoAN.NET_.ThongKeDatSan.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(16, 112);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1336, 606);
            this.reportViewer1.TabIndex = 0;
            // 
            // btnLoadDuLieu
            // 
            this.btnLoadDuLieu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadDuLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadDuLieu.Location = new System.Drawing.Point(590, 12);
            this.btnLoadDuLieu.Name = "btnLoadDuLieu";
            this.btnLoadDuLieu.Size = new System.Drawing.Size(341, 85);
            this.btnLoadDuLieu.TabIndex = 1;
            this.btnLoadDuLieu.Text = "Load Dữ Liệu";
            this.btnLoadDuLieu.UseVisualStyleBackColor = true;
            this.btnLoadDuLieu.Click += new System.EventHandler(this.btnLoadDuLieu_Click);
            // 
            // frmThongKeLichDS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 766);
            this.Controls.Add(this.btnLoadDuLieu);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmThongKeLichDS";
            this.Text = "frmQuanLiKinhDoanh";
            this.Load += new System.EventHandler(this.frmThongKe_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btnLoadDuLieu;



    }
}