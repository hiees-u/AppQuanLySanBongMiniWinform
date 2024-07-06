namespace DoAN.NET_.Forms
{
    partial class frmQuanLiSan
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýSânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýLoạiSânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_GiaLoaiSan = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_TenLoaiSan = new System.Windows.Forms.Label();
            this.txt_GiaLoaiSan = new System.Windows.Forms.TextBox();
            this.txt_TenLoaiSan = new System.Windows.Forms.TextBox();
            this.lbl_MaLoaiSan = new System.Windows.Forms.Label();
            this.txt_MaLoaiSan = new System.Windows.Forms.TextBox();
            this.lbl_TenSan = new System.Windows.Forms.Label();
            this.txt_TenSan = new System.Windows.Forms.TextBox();
            this.lbl_LoaiSan = new System.Windows.Forms.Label();
            this.lbl_MaSan = new System.Windows.Forms.Label();
            this.txt_MaSan = new System.Windows.Forms.TextBox();
            this.cbo_LoaiSan = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Res_btn = new System.Windows.Forms.Button();
            this.Upd_btn = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.Search_btn = new System.Windows.Forms.Button();
            this.Del_btn = new System.Windows.Forms.Button();
            this.lbl_mTa = new System.Windows.Forms.Label();
            this.txt_Mota = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýSânToolStripMenuItem,
            this.quảnLýLoạiSânToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(958, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýSânToolStripMenuItem
            // 
            this.quảnLýSânToolStripMenuItem.Checked = true;
            this.quảnLýSânToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.quảnLýSânToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quảnLýSânToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.quảnLýSânToolStripMenuItem.Name = "quảnLýSânToolStripMenuItem";
            this.quảnLýSânToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.quảnLýSânToolStripMenuItem.Text = "Quản lý sân";
            this.quảnLýSânToolStripMenuItem.Click += new System.EventHandler(this.quảnLýSânToolStripMenuItem_Click);
            // 
            // quảnLýLoạiSânToolStripMenuItem
            // 
            this.quảnLýLoạiSânToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quảnLýLoạiSânToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.quảnLýLoạiSânToolStripMenuItem.Name = "quảnLýLoạiSânToolStripMenuItem";
            this.quảnLýLoạiSânToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.quảnLýLoạiSânToolStripMenuItem.Text = "Quản lý loại sân";
            this.quảnLýLoạiSânToolStripMenuItem.Click += new System.EventHandler(this.quảnLýLoạiSânToolStripMenuItem_Click);
            // 
            // lbl_GiaLoaiSan
            // 
            this.lbl_GiaLoaiSan.AutoSize = true;
            this.lbl_GiaLoaiSan.Location = new System.Drawing.Point(6, 251);
            this.lbl_GiaLoaiSan.Name = "lbl_GiaLoaiSan";
            this.lbl_GiaLoaiSan.Size = new System.Drawing.Size(85, 16);
            this.lbl_GiaLoaiSan.TabIndex = 4;
            this.lbl_GiaLoaiSan.Text = "Giá Loại Sân";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_Mota);
            this.groupBox2.Controls.Add(this.lbl_mTa);
            this.groupBox2.Controls.Add(this.lbl_GiaLoaiSan);
            this.groupBox2.Controls.Add(this.lbl_TenLoaiSan);
            this.groupBox2.Controls.Add(this.txt_GiaLoaiSan);
            this.groupBox2.Controls.Add(this.txt_TenLoaiSan);
            this.groupBox2.Controls.Add(this.lbl_MaLoaiSan);
            this.groupBox2.Controls.Add(this.txt_MaLoaiSan);
            this.groupBox2.Controls.Add(this.lbl_TenSan);
            this.groupBox2.Controls.Add(this.txt_TenSan);
            this.groupBox2.Controls.Add(this.lbl_LoaiSan);
            this.groupBox2.Controls.Add(this.lbl_MaSan);
            this.groupBox2.Controls.Add(this.txt_MaSan);
            this.groupBox2.Controls.Add(this.cbo_LoaiSan);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(699, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 576);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // lbl_TenLoaiSan
            // 
            this.lbl_TenLoaiSan.AutoSize = true;
            this.lbl_TenLoaiSan.Location = new System.Drawing.Point(1, 150);
            this.lbl_TenLoaiSan.Name = "lbl_TenLoaiSan";
            this.lbl_TenLoaiSan.Size = new System.Drawing.Size(88, 16);
            this.lbl_TenLoaiSan.TabIndex = 9;
            this.lbl_TenLoaiSan.Text = "Tên Loại Sân";
            // 
            // txt_GiaLoaiSan
            // 
            this.txt_GiaLoaiSan.Location = new System.Drawing.Point(94, 248);
            this.txt_GiaLoaiSan.Name = "txt_GiaLoaiSan";
            this.txt_GiaLoaiSan.Size = new System.Drawing.Size(146, 22);
            this.txt_GiaLoaiSan.TabIndex = 3;
            this.txt_GiaLoaiSan.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyDownCheckNull);
            this.txt_GiaLoaiSan.Leave += new System.EventHandler(this.LeaveNullAllTextBox);
            // 
            // txt_TenLoaiSan
            // 
            this.txt_TenLoaiSan.Location = new System.Drawing.Point(94, 148);
            this.txt_TenLoaiSan.Name = "txt_TenLoaiSan";
            this.txt_TenLoaiSan.Size = new System.Drawing.Size(146, 22);
            this.txt_TenLoaiSan.TabIndex = 8;
            this.txt_TenLoaiSan.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyDownCheckNull);
            this.txt_TenLoaiSan.Leave += new System.EventHandler(this.LeaveNullAllTextBox);
            // 
            // lbl_MaLoaiSan
            // 
            this.lbl_MaLoaiSan.AutoSize = true;
            this.lbl_MaLoaiSan.Location = new System.Drawing.Point(6, 53);
            this.lbl_MaLoaiSan.Name = "lbl_MaLoaiSan";
            this.lbl_MaLoaiSan.Size = new System.Drawing.Size(83, 16);
            this.lbl_MaLoaiSan.TabIndex = 7;
            this.lbl_MaLoaiSan.Text = "Mã Loại Sân";
            // 
            // txt_MaLoaiSan
            // 
            this.txt_MaLoaiSan.Location = new System.Drawing.Point(94, 49);
            this.txt_MaLoaiSan.Name = "txt_MaLoaiSan";
            this.txt_MaLoaiSan.Size = new System.Drawing.Size(146, 22);
            this.txt_MaLoaiSan.TabIndex = 6;
            this.txt_MaLoaiSan.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyDownCheckNull);
            this.txt_MaLoaiSan.Leave += new System.EventHandler(this.LeaveNullAllTextBox);
            // 
            // lbl_TenSan
            // 
            this.lbl_TenSan.AutoSize = true;
            this.lbl_TenSan.Location = new System.Drawing.Point(6, 253);
            this.lbl_TenSan.Name = "lbl_TenSan";
            this.lbl_TenSan.Size = new System.Drawing.Size(59, 16);
            this.lbl_TenSan.TabIndex = 5;
            this.lbl_TenSan.Text = "Tên Sân";
            // 
            // txt_TenSan
            // 
            this.txt_TenSan.Location = new System.Drawing.Point(94, 247);
            this.txt_TenSan.Name = "txt_TenSan";
            this.txt_TenSan.Size = new System.Drawing.Size(146, 22);
            this.txt_TenSan.TabIndex = 4;
            this.txt_TenSan.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyDownCheckNull);
            this.txt_TenSan.Leave += new System.EventHandler(this.LeaveNullAllTextBox);
            // 
            // lbl_LoaiSan
            // 
            this.lbl_LoaiSan.AutoSize = true;
            this.lbl_LoaiSan.Location = new System.Drawing.Point(6, 151);
            this.lbl_LoaiSan.Name = "lbl_LoaiSan";
            this.lbl_LoaiSan.Size = new System.Drawing.Size(61, 16);
            this.lbl_LoaiSan.TabIndex = 3;
            this.lbl_LoaiSan.Text = "Loại Sân";
            // 
            // lbl_MaSan
            // 
            this.lbl_MaSan.AutoSize = true;
            this.lbl_MaSan.Location = new System.Drawing.Point(6, 55);
            this.lbl_MaSan.Name = "lbl_MaSan";
            this.lbl_MaSan.Size = new System.Drawing.Size(54, 16);
            this.lbl_MaSan.TabIndex = 2;
            this.lbl_MaSan.Text = "Mã Sân";
            // 
            // txt_MaSan
            // 
            this.txt_MaSan.Location = new System.Drawing.Point(94, 49);
            this.txt_MaSan.Name = "txt_MaSan";
            this.txt_MaSan.Size = new System.Drawing.Size(146, 22);
            this.txt_MaSan.TabIndex = 1;
            this.txt_MaSan.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyDownCheckNull);
            this.txt_MaSan.Leave += new System.EventHandler(this.LeaveNullAllTextBox);
            // 
            // cbo_LoaiSan
            // 
            this.cbo_LoaiSan.FormattingEnabled = true;
            this.cbo_LoaiSan.Location = new System.Drawing.Point(94, 147);
            this.cbo_LoaiSan.Name = "cbo_LoaiSan";
            this.cbo_LoaiSan.Size = new System.Drawing.Size(146, 24);
            this.cbo_LoaiSan.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(683, 484);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(6, 21);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.Size = new System.Drawing.Size(671, 457);
            this.dgv.TabIndex = 0;
            this.dgv.UseWaitCursor = true;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // txt_Search
            // 
            this.txt_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.Location = new System.Drawing.Point(92, 16);
            this.txt_Search.Multiline = true;
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(442, 26);
            this.txt_Search.TabIndex = 0;
            // 
            // add_btn
            // 
            this.add_btn.Enabled = false;
            this.add_btn.Location = new System.Drawing.Point(8, 30);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(87, 30);
            this.add_btn.TabIndex = 9;
            this.add_btn.Text = "Thêm";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên";
            // 
            // Res_btn
            // 
            this.Res_btn.Location = new System.Drawing.Point(287, 30);
            this.Res_btn.Name = "Res_btn";
            this.Res_btn.Size = new System.Drawing.Size(87, 30);
            this.Res_btn.TabIndex = 12;
            this.Res_btn.Text = "Reset";
            this.Res_btn.UseVisualStyleBackColor = true;
            this.Res_btn.Click += new System.EventHandler(this.Res_btn_Click);
            // 
            // Upd_btn
            // 
            this.Upd_btn.Enabled = false;
            this.Upd_btn.Location = new System.Drawing.Point(194, 30);
            this.Upd_btn.Name = "Upd_btn";
            this.Upd_btn.Size = new System.Drawing.Size(87, 30);
            this.Upd_btn.TabIndex = 11;
            this.Upd_btn.Text = "Sửa";
            this.Upd_btn.UseVisualStyleBackColor = true;
            this.Upd_btn.Click += new System.EventHandler(this.Upd_btn_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.Search_btn);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Controls.Add(this.txt_Search);
            this.groupBox.Location = new System.Drawing.Point(9, 64);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(684, 52);
            this.groupBox.TabIndex = 13;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Tìm Kiếm";
            // 
            // Search_btn
            // 
            this.Search_btn.Location = new System.Drawing.Point(540, 13);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(131, 30);
            this.Search_btn.TabIndex = 2;
            this.Search_btn.Text = "Tìm kiếm";
            this.Search_btn.UseVisualStyleBackColor = true;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // Del_btn
            // 
            this.Del_btn.Enabled = false;
            this.Del_btn.Location = new System.Drawing.Point(101, 30);
            this.Del_btn.Name = "Del_btn";
            this.Del_btn.Size = new System.Drawing.Size(87, 30);
            this.Del_btn.TabIndex = 10;
            this.Del_btn.Text = "Xóa";
            this.Del_btn.UseVisualStyleBackColor = true;
            this.Del_btn.Click += new System.EventHandler(this.Del_btn_Click);
            // 
            // lbl_mTa
            // 
            this.lbl_mTa.AutoSize = true;
            this.lbl_mTa.Location = new System.Drawing.Point(6, 333);
            this.lbl_mTa.Name = "lbl_mTa";
            this.lbl_mTa.Size = new System.Drawing.Size(47, 16);
            this.lbl_mTa.TabIndex = 10;
            this.lbl_mTa.Text = "Mô Tả";
            this.lbl_mTa.Visible = false;
            // 
            // txt_Mota
            // 
            this.txt_Mota.Location = new System.Drawing.Point(9, 352);
            this.txt_Mota.Multiline = true;
            this.txt_Mota.Name = "txt_Mota";
            this.txt_Mota.Size = new System.Drawing.Size(231, 218);
            this.txt_Mota.TabIndex = 11;
            this.txt_Mota.Visible = false;
            // 
            // frmQuanLiSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 617);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.Res_btn);
            this.Controls.Add(this.Upd_btn);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.Del_btn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmQuanLiSan";
            this.Text = "frmQuanLiSan";
            this.Load += new System.EventHandler(this.frmQuanLiSan_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýSânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýLoạiSânToolStripMenuItem;
        private System.Windows.Forms.Label lbl_GiaLoaiSan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_TenLoaiSan;
        private System.Windows.Forms.TextBox txt_GiaLoaiSan;
        private System.Windows.Forms.TextBox txt_TenLoaiSan;
        private System.Windows.Forms.Label lbl_MaLoaiSan;
        private System.Windows.Forms.TextBox txt_MaLoaiSan;
        private System.Windows.Forms.Label lbl_TenSan;
        private System.Windows.Forms.TextBox txt_TenSan;
        private System.Windows.Forms.Label lbl_LoaiSan;
        private System.Windows.Forms.Label lbl_MaSan;
        private System.Windows.Forms.TextBox txt_MaSan;
        private System.Windows.Forms.ComboBox cbo_LoaiSan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Res_btn;
        private System.Windows.Forms.Button Upd_btn;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.Button Del_btn;
        private System.Windows.Forms.TextBox txt_Mota;
        private System.Windows.Forms.Label lbl_mTa;
    }
}