namespace DoAN.NET_.Forms
{
    partial class frmHeThong
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.txt_UsName = new System.Windows.Forms.TextBox();
            this.lbl_GiaLoaiSan = new System.Windows.Forms.Label();
            this.lbl_disName = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txt_PS = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_disName = new System.Windows.Forms.TextBox();
            this.btnHuyFind = new System.Windows.Forms.Button();
            this.cbo_Find = new System.Windows.Forms.ComboBox();
            this.Search_btn = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnRes = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.quảnLýTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(645, 397);
            this.groupBox1.TabIndex = 25;
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
            this.dgv.Size = new System.Drawing.Size(633, 370);
            this.dgv.TabIndex = 0;
            this.dgv.UseWaitCursor = true;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // txt_UsName
            // 
            this.txt_UsName.Location = new System.Drawing.Point(121, 39);
            this.txt_UsName.Name = "txt_UsName";
            this.txt_UsName.Size = new System.Drawing.Size(157, 22);
            this.txt_UsName.TabIndex = 10;
            this.txt_UsName.TextChanged += new System.EventHandler(this.CheckEnabelAddBtn);
            // 
            // lbl_GiaLoaiSan
            // 
            this.lbl_GiaLoaiSan.AutoSize = true;
            this.lbl_GiaLoaiSan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GiaLoaiSan.Location = new System.Drawing.Point(8, 160);
            this.lbl_GiaLoaiSan.Name = "lbl_GiaLoaiSan";
            this.lbl_GiaLoaiSan.Size = new System.Drawing.Size(61, 13);
            this.lbl_GiaLoaiSan.TabIndex = 4;
            this.lbl_GiaLoaiSan.Text = "Password";
            // 
            // lbl_disName
            // 
            this.lbl_disName.AutoSize = true;
            this.lbl_disName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_disName.Location = new System.Drawing.Point(8, 44);
            this.lbl_disName.Name = "lbl_disName";
            this.lbl_disName.Size = new System.Drawing.Size(69, 13);
            this.lbl_disName.TabIndex = 9;
            this.lbl_disName.Text = "User Name";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(8, 97);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(84, 13);
            this.lblUserName.TabIndex = 7;
            this.lblUserName.Text = "Display Name";
            // 
            // txt_PS
            // 
            this.txt_PS.Location = new System.Drawing.Point(121, 157);
            this.txt_PS.Name = "txt_PS";
            this.txt_PS.Size = new System.Drawing.Size(157, 22);
            this.txt_PS.TabIndex = 4;
            this.txt_PS.TextChanged += new System.EventHandler(this.CheckEnabelAddBtn);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_UsName);
            this.groupBox2.Controls.Add(this.lbl_GiaLoaiSan);
            this.groupBox2.Controls.Add(this.lbl_disName);
            this.groupBox2.Controls.Add(this.lblUserName);
            this.groupBox2.Controls.Add(this.txt_PS);
            this.groupBox2.Controls.Add(this.txt_disName);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(666, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 505);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // txt_disName
            // 
            this.txt_disName.Location = new System.Drawing.Point(121, 94);
            this.txt_disName.Name = "txt_disName";
            this.txt_disName.Size = new System.Drawing.Size(157, 22);
            this.txt_disName.TabIndex = 1;
            this.txt_disName.TextChanged += new System.EventHandler(this.CheckEnabelAddBtn);
            // 
            // btnHuyFind
            // 
            this.btnHuyFind.Enabled = false;
            this.btnHuyFind.Location = new System.Drawing.Point(585, 16);
            this.btnHuyFind.Name = "btnHuyFind";
            this.btnHuyFind.Size = new System.Drawing.Size(54, 30);
            this.btnHuyFind.TabIndex = 4;
            this.btnHuyFind.Text = "Hủy";
            this.btnHuyFind.UseVisualStyleBackColor = false;
            this.btnHuyFind.Click += new System.EventHandler(this.btnHuyFind_Click);
            // 
            // cbo_Find
            // 
            this.cbo_Find.FormattingEnabled = true;
            this.cbo_Find.Location = new System.Drawing.Point(14, 18);
            this.cbo_Find.Name = "cbo_Find";
            this.cbo_Find.Size = new System.Drawing.Size(147, 21);
            this.cbo_Find.TabIndex = 3;
            // 
            // Search_btn
            // 
            this.Search_btn.Location = new System.Drawing.Point(448, 15);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(131, 30);
            this.Search_btn.TabIndex = 2;
            this.Search_btn.Text = "Tìm kiếm";
            this.Search_btn.UseVisualStyleBackColor = true;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.Location = new System.Drawing.Point(183, 16);
            this.txt_Search.Multiline = true;
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(259, 26);
            this.txt_Search.TabIndex = 0;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(141, 40);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(121, 34);
            this.btnSua.TabIndex = 22;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(268, 40);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(121, 34);
            this.btnDel.TabIndex = 21;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnRes
            // 
            this.btnRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRes.Location = new System.Drawing.Point(395, 40);
            this.btnRes.Name = "btnRes";
            this.btnRes.Size = new System.Drawing.Size(121, 34);
            this.btnRes.TabIndex = 20;
            this.btnRes.Text = "Reset";
            this.btnRes.UseVisualStyleBackColor = true;
            this.btnRes.Click += new System.EventHandler(this.btnRes_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(14, 40);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(121, 34);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // quảnLýTàiKhoảnToolStripMenuItem
            // 
            this.quảnLýTàiKhoảnToolStripMenuItem.Checked = true;
            this.quảnLýTàiKhoảnToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.quảnLýTàiKhoảnToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quảnLýTàiKhoảnToolStripMenuItem.Name = "quảnLýTàiKhoảnToolStripMenuItem";
            this.quảnLýTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.quảnLýTàiKhoảnToolStripMenuItem.Text = "Quản lý tài khoản";
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.btnHuyFind);
            this.groupBox.Controls.Add(this.cbo_Find);
            this.groupBox.Controls.Add(this.Search_btn);
            this.groupBox.Controls.Add(this.txt_Search);
            this.groupBox.Location = new System.Drawing.Point(14, 80);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(646, 52);
            this.groupBox.TabIndex = 23;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Tìm Kiếm";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýTàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(968, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // frmHeThong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 541);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnRes);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmHeThong";
            this.Text = "frmHeThong";
            this.Load += new System.EventHandler(this.frmHeThong_Load_1);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox txt_UsName;
        private System.Windows.Forms.Label lbl_GiaLoaiSan;
        private System.Windows.Forms.Label lbl_disName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txt_PS;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_disName;
        private System.Windows.Forms.Button btnHuyFind;
        private System.Windows.Forms.ComboBox cbo_Find;
        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnRes;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ToolStripMenuItem quảnLýTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.MenuStrip menuStrip1;

    }
}